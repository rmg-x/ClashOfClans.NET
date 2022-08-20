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
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("townHallLevel")]
        public int TownhallLevel { get; private set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; private set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; private set; }

        [JsonPropertyName("bestTrophies")]
        public int BestTrophies { get; private set; }

        [JsonPropertyName("warStars")]
        public int WarStars { get; private set; }

        [JsonPropertyName("attackWins")]
        public int AttackWins { get; private set; }

        [JsonPropertyName("defenseWins")]
        public int DefenseWins { get; private set; }

        [JsonPropertyName("builderHallLevel")]
        public int BuliderHallLevel { get; private set; }

        [JsonPropertyName("versusTrophies")]
        public int VersusTrophies { get; private set; }

        [JsonPropertyName("bestVersusTrophies")]
        public int BestVersusTrophies { get; private set; }

        [JsonPropertyName("versusBattleWins")]
        public int VersusBattleWins { get; private set; }

        [JsonPropertyName("role")]
        public ClanMemberRole Role { get; private set; }

        [JsonPropertyName("donations")]
        public int Donations { get; private set; }

        [JsonPropertyName("donationsReceived")]
        public int DonationsReceived { get; private set; }

        [JsonPropertyName("clan")]
        public ClashPlayerClan Clan { get; private set; }

        [JsonPropertyName("league")]
        public League League { get; private set; }

        [JsonPropertyName("achievements")]
        public IEnumerable<ClashPlayerAchievement> Achievements { get; private set; }

        [JsonPropertyName("versusBattleWinCount")]
        public int VersusBattleWinCount { get; private set; }

        [JsonPropertyName("troops")]
        public IEnumerable<ClashEntity> Troops { get; private set; }

        [JsonPropertyName("heroes")]
        public IEnumerable<ClashEntity> Heroes { get; private set; }

        [JsonPropertyName("spells")]
        public IEnumerable<ClashEntity> Spells { get; private set; }

        public bool Equals(ClashPlayer other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
