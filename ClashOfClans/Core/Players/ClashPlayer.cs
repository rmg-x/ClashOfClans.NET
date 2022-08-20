using ClashOfClans.Core.Leagues;
using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayer : IClashPlayer
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "townHallLevel")]
        public int TownhallLevel { get; private set; }

        [DataMember(Name = "expLevel")]
        public int ExpLevel { get; private set; }

        [DataMember(Name = "trophies")]
        public int Trophies { get; private set; }

        [DataMember(Name = "bestTrophies")]
        public int BestTrophies { get; private set; }

        [DataMember(Name = "warStars")]
        public int WarStars { get; private set; }

        [DataMember(Name = "attackWins")]
        public int AttackWins { get; private set; }

        [DataMember(Name = "defenseWins")]
        public int DefenseWins { get; private set; }

        [DataMember(Name = "builderHallLevel")]
        public int BuliderHallLevel { get; private set; }

        [DataMember(Name = "versusTrophies")]
        public int VersusTrophies { get; private set; }

        [DataMember(Name = "bestVersusTrophies")]
        public int BestVersusTrophies { get; private set; }

        [DataMember(Name = "versusBattleWins")]
        public int VersusBattleWins { get; private set; }

        [DataMember(Name = "role")]
        public ClanMemberRole Role { get; private set; }

        [DataMember(Name = "donations")]
        public int Donations { get; private set; }

        [DataMember(Name = "donationsReceived")]
        public int DonationsReceived { get; private set; }

        [DataMember(Name = "clan")]
        public ClashPlayerClan Clan { get; private set; }

        [DataMember(Name = "league")]
        public League League { get; private set; }

        [DataMember(Name = "achievements")]
        public IEnumerable<ClashPlayerAchievement> Achievements { get; private set; }

        [DataMember(Name = "versusBattleWinCount")]
        public int VersusBattleWinCount { get; private set; }

        [DataMember(Name = "troops")]
        public IEnumerable<ClashEntity> Troops { get; private set; }

        [DataMember(Name = "heroes")]
        public IEnumerable<ClashEntity> Heroes { get; private set; }

        [DataMember(Name = "spells")]
        public IEnumerable<ClashEntity> Spells { get; private set; }
    }
}
