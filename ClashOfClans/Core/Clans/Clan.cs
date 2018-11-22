using ClashOfClans.Core.Clans.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class Clan : IClan
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "location")]
        public ClanLocation Location { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "clanPoints")]
        public int ClanPoints { get; private set; }

        [DataMember(Name = "clanVersusPoints")]
        public int ClanVersusPoints { get; private set; }

        [DataMember(Name = "members")]
        public int MemberCount { get; private set; }
    }
}
