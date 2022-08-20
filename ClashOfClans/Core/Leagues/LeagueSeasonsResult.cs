using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonsResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<LeagueSeason> LeagueSeasons { get; set; }
    }
}
