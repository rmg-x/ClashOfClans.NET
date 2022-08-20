using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface IClashLeagues
    {
        /// <summary>
        /// Gets a list of all leagues
        /// </summary>
        /// <returns><see cref="IEnumerable{League}"/></returns>
        Task<IEnumerable<League>> GetLeaguesAsync();

        /// <summary>
        /// Get league information from a league id
        /// </summary>
        /// <param name="leagueId">League id to get</param>
        /// <returns><see cref="League"/></returns>
        Task<League> GetLeagueByIdAsync(int leagueId);

        /// <summary>
        /// Gets all league seasons, only available for "Legendary League"
        /// </summary>
        /// <param name="leagueId">League id</param>
        /// <returns><see cref="IEnumerable{LeagueSeason}"/></returns>
        /// <exception cref="ArgumentException"></exception>
        Task<IEnumerable<LeagueSeason>> GetLeagueSeasonsAsync(int leagueId);

        /// <summary>
        /// Get league season rankings, only available for "Legendary League"
        /// </summary>
        /// <param name="leagueId">League id</param>
        /// <param name="seasonId">Season id</param>
        /// <returns><see cref="IEnumerable{LeagueSeasonRanking}"/></returns>
        Task<IEnumerable<LeagueSeasonRanking>> GetLeagueSeasonRankingsAsync(int leagueId, string seasonId);
    }
}
