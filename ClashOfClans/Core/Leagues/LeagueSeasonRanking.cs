using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRanking : ILeagueSeasonRanking, IEquatable<LeagueSeasonRanking>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; private set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; private set; }

        [JsonPropertyName("attackWins")]
        public int AttackWins { get; private set; }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; private set; }

        [JsonPropertyName("rank")]
        public int Rank { get; private set; }

        [JsonPropertyName("clan")]
        public LeagueSeasonClan Clan { get; private set; }

        public bool Equals(LeagueSeasonRanking other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
