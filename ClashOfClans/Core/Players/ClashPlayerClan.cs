using ClashOfClans.Core.Clans;
using ClashOfClans.Core.Players.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerClan : IClashPlayerClan
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }
    }
}
