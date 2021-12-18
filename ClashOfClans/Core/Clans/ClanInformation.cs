using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Locations;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanInformation : IClanInformation, IEquatable<ClanInformation>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("type")]
        public ClanType Type { get; private set; }

        [JsonPropertyName("description")]
        public string Description { get; private set; }

        [JsonPropertyName("location")]
        public Location Location { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; private set; }

        [JsonPropertyName("clanPoints")]
        public int ClanPoints { get; private set; }

        [JsonPropertyName("clanVersusPoints")]
        public int ClanVersusPoints { get; private set; }

        [JsonPropertyName("requiredTrophies")]
        public int RequiredTrophies { get; private set; }

        [JsonPropertyName("warFrequency")]
        public WarFrequency WarFrequency { get; private set; }

        [JsonPropertyName("warWinStreak")]
        public int WarWinStreak { get; private set; }

        [JsonPropertyName("warWins")]
        public int WarWins { get; private set; }

        [JsonPropertyName("warTies")]
        public int WarTies { get; private set; }

        [JsonPropertyName("warLosses")]
        public int WarLosses { get; private set; }

        [JsonPropertyName("isWarLogPublic")]
        public bool IsWarLogPublic { get; private set; }

        [JsonPropertyName("members")]
        public int MemberCount { get; private set; }

        [JsonPropertyName("memberList")]
        public IEnumerable<ClanMember> Members { get; private set; }

        public bool Equals(ClanInformation other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
