using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroup : ILeagueGroup, IEquatable<LeagueGroup>
    {
        [DataMember(Name = "state")]
        public WarState WarState { get; private set; }

        [DataMember(Name = "season")]
        public string Season { get; private set; }

        [DataMember(Name = "clans")]
        public IEnumerable<LeagueGroupClan> Clans { get; private set; }

        [DataMember(Name = "rounds")]
        public IEnumerable<LeagueGroupRound> Rounds { get; private set; }

        public bool Equals(LeagueGroup other)
        {
            if (other == null)
                return false;

            return WarState == other.WarState
                && Season == other.Season;
        }
    }
}
