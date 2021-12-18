using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRankingResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<LeagueSeasonRanking> LeagueSeasonRankings { get; private set; }
    }
}
