using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Utils
{
    public static class ClashExtensions
    {
        public static bool IsNotCriticalFailure(this HttpResponseMessage httpMsg) => httpMsg.StatusCode == HttpStatusCode.NotFound;

        public static string GetWarFrequency(this WarFrequency? warFrequency)
        {
            string warFreq;

            switch (warFrequency)
            {
                case WarFrequency.Always:
                    warFreq = "always";
                    break;
                case WarFrequency.LessThanOncePerWeek:
                    warFreq = "lessThanOncePerWeek";
                    break;
                case WarFrequency.MoreThanOncePerWeek:
                    warFreq = "moreThanOncePerWeek";
                    break;
                case WarFrequency.OncePerWeek:
                    warFreq = "oncePerWeek";
                    break;
                case WarFrequency.Never:
                    warFreq = "never";
                    break;
                case WarFrequency.Unknown:
                    warFreq = "unknown";
                    break;
                default:
                    throw new Exception($"Invalid war frequency \"{warFrequency.ToString()}\"");
            }

            return warFreq;
        }

        public static async Task<Stream> ToStreamAsync(this string str)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);

            await writer.WriteAsync(str).ConfigureAwait(false);
            await writer.FlushAsync().ConfigureAwait(false);

            stream.Position = 0;

            return stream;
        }
    }
}
