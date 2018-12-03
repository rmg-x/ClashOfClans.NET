using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Utils;
using System;

namespace ClashOfClans
{
    public class ClashOfClansClient : IClashOfClansClient, IDisposable
    {
        private HttpClientService HttpClientService { get; set; }

        /// <summary>
        /// Constructor for ClashOfClansClient
        /// </summary>
        /// <param name="token">Clash of Clans API token</param>
        /// <param name="timeout">Timeout for all requests (default is 100 seconds)</param>
        public ClashOfClansClient(string token, TimeSpan timeout = default)
        {
            HttpClientService = HttpClientService.GetInstance(token, timeout);

            Clans = new ClashClans(HttpClientService);
        }

        /// <summary>
        /// Pertains to the "Clans" section of the API
        /// </summary>
        public IClashClans Clans { get; private set; }

        public void Dispose() => HttpClientService.Dispose();
    }
}
