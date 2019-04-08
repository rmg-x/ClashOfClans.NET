using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface IClashLeagues
    {
        Task<IEnumerable<ILeague>> GetLeaguesAsync();

        Task<ILeague> GetLeagueByIdAsync(int leagueId);

        Task<IEnumerable<ILeagueSeason>> GetLeagueSeasonsAsync(int leagueId);

        Task<IEnumerable<ILeagueSeasonRanking>> GetLeagueSeasonRankingsAsync(int leagueId, string seasonId);
    }
}
