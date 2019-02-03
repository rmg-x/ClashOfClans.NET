using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanBadges : IClanBadges, IEquatable<ClanBadges>
    {
        [DataMember(Name = "small")]
        public string Small { get; private set; }

        [DataMember(Name = "medium")]
        public string Medium { get; private set; }

        [DataMember(Name = "large")]
        public string Large { get; private set; }

        public bool Equals(ClanBadges other)
        {
            if (other == null)
                return false;

            return Small == other.Small
                && Medium == other.Medium
                && Large == other.Large;
        }
    }
}
