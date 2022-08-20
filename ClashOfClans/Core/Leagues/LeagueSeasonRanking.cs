using ClashOfClans.Core.Leagues.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonRanking : ILeagueSeasonRanking
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "expLevel")]
        public int ExpLevel { get; private set; }

        [DataMember(Name = "trophies")]
        public int Trophies { get; private set; }

        [DataMember(Name = "attackWins")]
        public int AttackWins { get; private set; }

        [DataMember(Name = "defenseWins")]
        public int DefenseWins { get; private set; }

        [DataMember(Name = "rank")]
        public int Rank { get; private set; }

        [DataMember(Name = "clan")]
        public LeagueSeasonClan Clan { get; private set; }
    }
}
