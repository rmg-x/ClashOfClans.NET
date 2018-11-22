using ClashOfClans.Core.Clans.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanBadges : IClanBadges
    {
        [DataMember(Name = "small")]
        public string Small { get; private set; }

        [DataMember(Name = "medium")]
        public string Medium { get; private set; }

        [DataMember(Name = "large")]
        public string Large { get; private set; }
    }
}
