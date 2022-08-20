using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupClanMember : ILeageGroupClanMember, IEquatable<LeagueGroupClanMember>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("townHallLevel")]
        public int TownhallLevel { get; set; }

        public bool Equals(LeagueGroupClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
