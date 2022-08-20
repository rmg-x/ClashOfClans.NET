using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogClan : IWarLogClan, IEquatable<WarLogClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonPropertyName("attacks")]
        public int Attacks { get; set; }

        [JsonPropertyName("stars")]
        public int Stars { get; set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; set; }

        [JsonPropertyName("expEarned")]
        public int ExpEarned { get; set; }

        public bool Equals(WarLogClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
