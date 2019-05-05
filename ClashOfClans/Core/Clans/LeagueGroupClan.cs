using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupClan : ILeagueGroupClan, IEquatable<LeagueGroupClan>
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [DataMember(Name = "members")]
        public IEnumerable<LeagueGroupClanMember> Members { get; private set; }

        public bool Equals(LeagueGroupClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
