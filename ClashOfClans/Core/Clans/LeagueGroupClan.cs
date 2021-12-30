using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupClan : ILeagueGroupClan, IEquatable<LeagueGroupClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; set; }

        [JsonPropertyName("members")]
        public IEnumerable<LeagueGroupClanMember> Members { get; set; }

        public bool Equals(LeagueGroupClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
