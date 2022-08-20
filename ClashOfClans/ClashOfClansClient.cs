using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Leagues;
using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Locations;
using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Players;
using ClashOfClans.Core.Players.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Net;
using System.Net.Sockets;
using System.Linq;

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
        /// <param name="UseRecommendedRateLimits">Boolean to toggle recommended rate limits</param>
        public ClashOfClansClient(string token, TimeSpan timeout = default, bool UseRecommendedRateLimits = true)
        {
            HttpClientService = HttpClientService.CreateService(token, timeout, UseRecommendedRateLimits);

            Clans = new ClashClans(HttpClientService);
            Locations = new ClashLocations(HttpClientService);
            Leagues = new ClashLeagues(HttpClientService);
            Players = new ClashPlayers(HttpClientService);
        }

        /// <summary>
        /// Pertains to the "Clans" section of the API
        /// </summary>
        public IClashClans Clans { get; private set; }

        /// <summary>
        /// Pertains to the "Locations" section of the API
        /// </summary>
        public IClashLocations Locations { get; private set; }

        /// <summary>
        /// Pertains to the "Leagues" section of the API
        /// </summary>
        public IClashLeagues Leagues { get; private set; }

        /// <summary>
        /// Pertains to the "Players" section of the API
        /// </summary>
        public IClashPlayers Players { get; private set; }

        public void Dispose() => HttpClientService.Dispose();
    }
}
