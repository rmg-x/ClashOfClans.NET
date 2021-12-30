using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeaguesResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<League> Leagues { get; set; }
    }
}
