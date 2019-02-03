using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerClan : IClashPlayerClan, IEquatable<ClashPlayerClan>
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        public bool Equals(ClashPlayerClan other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
