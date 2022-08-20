using ClashOfClans.Core.Clans.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanSearchResult : IClanSearchResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<Clan> Clans { get; set; }
    }
}
