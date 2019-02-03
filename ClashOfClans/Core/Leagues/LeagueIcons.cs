using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueIcons : ILeagueIcons, IEquatable<LeagueIcons>
    {
        [DataMember(Name = "small")]
        public string Small { get; private set; }

        [DataMember(Name = "tiny")]
        public string Tiny { get; private set; }

        [DataMember(Name = "medium")]
        public string Medium { get; private set; }

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
