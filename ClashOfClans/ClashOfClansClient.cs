using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Locations;
using ClashOfClans.Core.Locations.Interfaces;
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
        /// <param name="UsePreemptiveRateLimits">Boolean to toggle Preemptive rate limits</param>
        public ClashOfClansClient(string token, TimeSpan timeout = default, bool UsePreemptiveRateLimits = true)
        {
            HttpClientService = HttpClientService.GetInstance(token, timeout, UsePreemptiveRateLimits);

            Clans = new ClashClans(HttpClientService);
            Locations = new ClashLocations(HttpClientService);
        }

        /// <summary>
        /// Pertains to the "Clans" section of the API
        /// </summary>
        public IClashClans Clans { get; private set; }

        /// <summary>
        /// Pertains to the "Locations" section of the API
        /// </summary>
        public IClashLocations Locations { get; private set; }

        public void Dispose() => HttpClientService.Dispose();
    }
}
