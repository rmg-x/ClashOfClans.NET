using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonClan : ILeagueSeasonClan, IEquatable<LeagueSeasonClan>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        public bool Equals(LeagueSeasonClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
