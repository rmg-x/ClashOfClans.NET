using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Leagues
{
    public class ClashLeagues : IClashLeagues
    {
        private HttpClientService _httpClientService { get; set; }

        public ClashLeagues(HttpClientService httpClientService) => _httpClientService = httpClientService;

        /// <summary>
        /// Gets a list of all leagues
        /// </summary>
        /// <returns><see cref="IEnumerable{League}"/></returns>
        public async Task<IEnumerable<ILeague>> GetLeaguesAsync()
        {
            var result = await _httpClientService.RequestAsync<LeaguesResult>("leagues");

            return result.Leagues;
        }

        /// <summary>
        /// Get league information from a league id
        /// </summary>
        /// <param name="leagueId">League id to get</param>
        /// <returns><see cref="League"/></returns>
        public async Task<ILeague> GetLeagueByIdAsync(int leagueId)
        {
            var result = await _httpClientService.RequestAsync<League>($"leagues/{leagueId}");

            return result;
        }

        /// <summary>
        /// Gets all league seasons, only available for "Legendary League"
        /// </summary>
        /// <param name="leagueId">League id</param>
        /// <returns><see cref="IEnumerable{LeagueSeason}"/></returns>
        /// <exception cref="ArgumentException"></exception>
        public async Task<IEnumerable<ILeagueSeason>> GetLeagueSeasonsAsync(int leagueId)
        {
            if (leagueId != LeagueConstants.LegendLeague)
                throw new ArgumentException($"Seasons are only available for \"Legendary League\"", nameof(leagueId));

            var result = await _httpClientService.RequestAsync<LeagueSeasonsResult>($"leagues/{leagueId}/seasons");

            return result.LeagueSeasons;
        }

        /// <summary>
        /// Get league season rankings, only available for "Legendary League"
        /// </summary>
        /// <param name="leagueId">League id</param>
        /// <param name="seasonId">Season id</param>
        /// <returns><see cref="IEnumerable{LeagueSeasonRanking}"/></returns>
        public async Task<IEnumerable<ILeagueSeasonRanking>> GetLeagueSeasonRankingsAsync(int leagueId, string seasonId)
        {
            var result = await _httpClientService.RequestAsync<LeagueSeasonRankingResult>($"leagues/{leagueId}/seasons/{HttpUtility.UrlEncode(seasonId)}");

            return result.LeagueSeasonRankings;
        }
    }
}
