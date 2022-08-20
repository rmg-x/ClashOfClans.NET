using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerClan : IClashPlayerClan, IEquatable<ClashPlayerClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; set; }

        public bool Equals(ClashPlayerClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
