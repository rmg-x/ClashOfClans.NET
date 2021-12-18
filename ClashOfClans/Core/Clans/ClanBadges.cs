using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanBadges : IClanBadges, IEquatable<ClanBadges>
    {
        [JsonPropertyName("small")]
        public string Small { get; private set; }

        [JsonPropertyName("medium")]
        public string Medium { get; private set; }

        [JsonPropertyName("large")]
        public string Large { get; private set; }

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
