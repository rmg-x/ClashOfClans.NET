using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRankingResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<LeagueSeasonRanking> LeagueSeasonRankings { get; private set; }
    }
}
