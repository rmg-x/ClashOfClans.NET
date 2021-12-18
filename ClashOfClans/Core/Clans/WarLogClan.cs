using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogClan : IWarLogClan, IEquatable<WarLogClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; private set; }

        [JsonPropertyName("attacks")]
        public int Attacks { get; private set; }

        [JsonPropertyName("stars")]
        public int Stars { get; private set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; private set; }

        [JsonPropertyName("expEarned")]
        public int ExpEarned { get; private set; }

        public bool Equals(WarLogClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
