using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRankingResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<LeagueSeasonRanking> LeagueSeasonRankings { get; private set; }
    }
}
