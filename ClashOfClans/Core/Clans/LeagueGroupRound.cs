using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupRound : ILeagueGroupRound, IEquatable<LeagueGroupRound>
    {
        [DataMember(Name = "warTags")]
        public IEnumerable<string> WarTags { get; private set; }

        public bool Equals(LeagueGroupRound other)
        {
            if (other == null)
                return false;

            return WarTags == other.WarTags;
        }
    }
}
