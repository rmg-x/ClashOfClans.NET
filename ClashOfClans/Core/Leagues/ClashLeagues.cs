using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Leagues
{
    public class ClashLeagues : IClashLeagues
    {
        private HttpClientService _httpClientService { get; set; }

        public ClashLeagues(HttpClientService httpClientService) => _httpClientService = httpClientService;

        /// <summary>
        /// Gets a list of all leagues.
        /// </summary>
        /// <returns><see cref="IEnumerable{League}"/></returns>
        public async Task<IEnumerable<League>> GetLeaguesAsync()
        {
            var result = await _httpClientService.RequestAsync<LeaguesResult>("leagues");

            return result.Leagues;
        }
    }
}
