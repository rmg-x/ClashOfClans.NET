using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanBadges : IClanBadges, IEquatable<ClanBadges>
    {
        [JsonPropertyName("small")]
        public string Small { get; set; }

        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        [JsonPropertyName("large")]
        public string Large { get; set; }

        public bool Equals(ClanBadges other)
        {
            if (other == null)
                return false;

            return Small == other.Small
                && Medium == other.Medium
                && Large == other.Large;
        }
    }
}
