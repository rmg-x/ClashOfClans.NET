using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRanking : ILeagueSeasonRanking, IEquatable<LeagueSeasonRanking>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("attackWins")]
        public int AttackWins { get; set; }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("clan")]
        public LeagueSeasonClan Clan { get; set; }

        public bool Equals(LeagueSeasonRanking other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
