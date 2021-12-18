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
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        public bool Equals(ClashPlayerClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
