using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Goldpass;
using ClashOfClans.Core.GoldPass.Interfaces;
using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Leagues;
using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Locations;
using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Players;
using ClashOfClans.Core.Players.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ClashOfClans
{
    public class ClashOfClansClient : IClashOfClansClient
    {
        /// <summary>
        /// Constructor for ClashOfClansClient, creates a new <see cref="HttpClient" /> each time.
        /// </summary>
        /// <param name="apiToken">API token</param>
        public ClashOfClansClient(string apiToken)
            : this(apiToken, new HttpClient())
        { }

        /// <summary>
        /// Constructor for ClashOfClansClient, uses <see cref="IHttpClientFactory" /> to create the HTTP client.
        /// </summary>
        /// <param name="apiToken"></param>
        /// <param name="httpClientFactory"></param>
        public ClashOfClansClient(string apiToken, IHttpClientFactory httpClientFactory) 
            : this(apiToken, httpClientFactory.CreateClient())
        { }

        internal ClashOfClansClient(string apiToken, HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(ClashConstants.ApiBaseAddress);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(ClashConstants.ApiAuthScheme, apiToken);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(ClashConstants.MediaType));

            Clans = new ClashClans(httpClient);
            Locations = new ClashLocations(httpClient);
            GoldPass = new ClashGoldPass(httpClient);
            Leagues = new ClashLeagues(httpClient);
            Players = new ClashPlayers(httpClient);
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
        /// Pertains to the "GoldPass" section of the API
        /// </summary>
        public IClashGoldPass GoldPass { get; private set; }

        /// <summary>
        /// Pertains to the "Leagues" section of the API
        /// </summary>
        public IClashLeagues Leagues { get; private set; }

        /// <summary>
        /// Pertains to the "Players" section of the API
        /// </summary>
        public IClashPlayers Players { get; private set; }
    }
}
