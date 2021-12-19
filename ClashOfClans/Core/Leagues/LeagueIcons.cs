using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueIcons : ILeagueIcons, IEquatable<LeagueIcons>
    {
        [JsonPropertyName("small")]
        public string Small { get; set; }

        [JsonPropertyName("tiny")]
        public string Tiny { get; set; }

        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        public bool Equals(LeagueIcons other)
        {
            if (other == null)
                return false;

            return Small == other.Small
                && Tiny == other.Tiny
                && Medium == other.Medium;
        }
    }
}
