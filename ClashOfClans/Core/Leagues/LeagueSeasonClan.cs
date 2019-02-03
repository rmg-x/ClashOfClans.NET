using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonClan : ILeagueSeasonClan, IEquatable<LeagueSeasonClan>
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        public bool Equals(LeagueSeasonClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
