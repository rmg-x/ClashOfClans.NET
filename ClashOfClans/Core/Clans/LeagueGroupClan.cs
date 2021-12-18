using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupClan : ILeagueGroupClan, IEquatable<LeagueGroupClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [JsonPropertyName("members")]
        public IEnumerable<LeagueGroupClanMember> Members { get; private set; }

        public bool Equals(LeagueGroupClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
