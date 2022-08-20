using ClashOfClans.Core.Leagues.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueIcons : ILeagueIcons
    {
        [DataMember(Name = "small")]
        public string Small { get; private set; }

        [DataMember(Name = "tiny")]
        public string Tiny { get; private set; }

        [DataMember(Name = "medium")]
        public string Medium { get; private set; }
    }
}
