using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupClanMember : ILeageGroupClanMember, IEquatable<LeagueGroupClanMember>
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "townHallLevel")]
        public int TownhallLevel { get; private set; }

        public bool Equals(LeagueGroupClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
