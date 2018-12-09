using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface IClashLeagues
    {
        Task<IEnumerable<League>> GetLeaguesAsync();

        Task<League> GetLeagueByIdAsync(int leagueId);

        Task<IEnumerable<LeagueSeason>> GetLeagueSeasonsAsync(int leagueId);

        Task<IEnumerable<LeagueSeasonRanking>> GetLeagueSeasonRankingsAsync(int leagueId, string seasonId);
    }
}
