using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogOpponent : IWarLogOpponent, IEquatable<WarLogOpponent>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonPropertyName("stars")]
        public int Stars { get; set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; set; }

        public bool Equals(WarLogOpponent other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
