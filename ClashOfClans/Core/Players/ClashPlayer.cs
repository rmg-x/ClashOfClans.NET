using ClashOfClans.Core.Leagues;
using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayer : IClashPlayer, IEquatable<ClashPlayer>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("townHallLevel")]
        public int TownhallLevel { get; set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("bestTrophies")]
        public int BestTrophies { get; set; }

        [JsonPropertyName("warStars")]
        public int WarStars { get; set; }

        [JsonPropertyName("attackWins")]
        public int AttackWins { get; set; }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; set; }

        [JsonPropertyName("builderHallLevel")]
        public int BuliderHallLevel { get; set; }

        [JsonPropertyName("versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonPropertyName("bestVersusTrophies")]
        public int BestVersusTrophies { get; set; }

        [JsonPropertyName("versusBattleWins")]
        public int VersusBattleWins { get; set; }

        [JsonPropertyName("role")]
        public ClanMemberRole Role { get; set; }

        [JsonPropertyName("donations")]
        public int Donations { get; set; }

        [JsonPropertyName("donationsReceived")]
        public int DonationsReceived { get; set; }

        [JsonPropertyName("clan")]
        public ClashPlayerClan Clan { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("achievements")]
        public IEnumerable<ClashPlayerAchievement> Achievements { get; set; }

        [JsonPropertyName("versusBattleWinCount")]
        public int VersusBattleWinCount { get; set; }

        [JsonPropertyName("troops")]
        public IEnumerable<ClashEntity> Troops { get; set; }

        [JsonPropertyName("heroes")]
        public IEnumerable<ClashEntity> Heroes { get; set; }

        [JsonPropertyName("spells")]
        public IEnumerable<ClashEntity> Spells { get; set; }

        public bool Equals(ClashPlayer other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
