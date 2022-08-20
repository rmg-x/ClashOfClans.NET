using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClashOfClans.Core.Utils
{
    public class TimeSpanSemaphore : IDisposable
    {
        private SemaphoreSlim _pool;

        private TimeSpan _resetSpan;

        private Queue<DateTime> _releaseTimes;

        private object _queueLock = new object();

        public TimeSpanSemaphore(int maxCount, TimeSpan resetSpan)
        {
            _pool = new SemaphoreSlim(maxCount, maxCount);
            _resetSpan = resetSpan;

            _releaseTimes = new Queue<DateTime>(maxCount);
            for (int i = 0; i < maxCount; i++)
            {
                _releaseTimes.Enqueue(DateTime.MinValue);
            }
        }

        public void Wait(CancellationToken cancelToken = default)
        {
            _pool.Wait(cancelToken);

            DateTime oldestRelease;
            lock (_queueLock)
            {
                oldestRelease = _releaseTimes.Dequeue();
            }

            DateTime now = DateTime.UtcNow;
            DateTime windowReset = oldestRelease.Add(_resetSpan);
            if (windowReset > now)
            {
                int sleepMilliseconds = Math.Max((int)(windowReset.Subtract(now).Ticks / TimeSpan.TicksPerMillisecond), 1);

                bool cancelled = cancelToken.WaitHandle.WaitOne(sleepMilliseconds);
                if (cancelled)
                {
                    Release();
                    cancelToken.ThrowIfCancellationRequested();
                }
            }
        }

        public void Release()
        {
            lock (_queueLock)
            {
                _releaseTimes.Enqueue(DateTime.UtcNow);
            }
            _pool.Release();
        }

        public void Dispose() => _pool.Dispose();
    }
}
