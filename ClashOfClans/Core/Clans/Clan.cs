using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Locations;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class Clan : IClan, IEquatable<Clan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public ClanType Type { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonPropertyName("clanPoints")]
        public int ClanPoints { get; set; }

        [JsonPropertyName("clanVersusPoints")]
        public int ClanVersusPoints { get; set; }

        [JsonPropertyName("requiredTrophies")]
        public int RequiredTrophies { get; set; }

        [JsonPropertyName("warFrequency")]
        public WarFrequency WarFrequency { get; set; }

        [JsonPropertyName("warWinStreak")]
        public int WarWinStreak { get; set; }

        [JsonPropertyName("warWins")]
        public int WarWins { get; set; }

        [JsonPropertyName("isWarLogPublic")]
        public bool IsWarLogPublic { get; set; }

        [JsonPropertyName("members")]
        public int MemberCount { get; set; }

        public bool Equals(Clan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
