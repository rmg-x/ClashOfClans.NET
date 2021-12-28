using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Leagues
{
    public class ClashLeagues : IClashLeagues
    {
        private readonly HttpClient _httpClient;

        public ClashLeagues(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ILeague>> GetLeaguesAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<LeaguesResult>("leagues", ClashConstants.DefaultJsonSerializerOptions);

            return result.Leagues;
        }

        /// <inheritdoc />
        public async Task<ILeague> GetLeagueByIdAsync(int leagueId)
        {
            var result = await _httpClient.GetFromJsonAsync<League>($"leagues/{leagueId}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ILeagueSeason>> GetLeagueSeasonsAsync(int leagueId)
        {
            if (leagueId != LeagueConstants.LegendLeague)
            {
                throw new ArgumentException($"Seasons are only available for \"Legendary League\"", nameof(leagueId));
            }

            var result = await _httpClient.GetFromJsonAsync<LeagueSeasonsResult>($"leagues/{leagueId}/seasons", ClashConstants.DefaultJsonSerializerOptions);

            return result.LeagueSeasons;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<ILeagueSeasonRanking>> GetLeagueSeasonRankingsAsync(int leagueId, string seasonId)
        {
            var result = await _httpClient.GetFromJsonAsync<LeagueSeasonRankingResult>($"leagues/{leagueId}/seasons/{HttpUtility.UrlEncode(seasonId)}",
                                                                                       ClashConstants.DefaultJsonSerializerOptions);

            return result.LeagueSeasonRankings;
        }
    }
}
