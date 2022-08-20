using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Locations;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanInformation : IClanInformation
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "type")]
        public ClanType Type { get; private set; }

        [DataMember(Name = "description")]
        public string Description { get; private set; }

        [DataMember(Name = "location")]
        public Location Location { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "clanPoints")]
        public int ClanPoints { get; private set; }

        [DataMember(Name = "clanVersusPoints")]
        public int ClanVersusPoints { get; private set; }

        [DataMember(Name = "requiredTrophies")]
        public int RequiredTrophies { get; private set; }

        [DataMember(Name = "warFrequency")]
        public WarFrequency WarFrequency { get; private set; }

        [DataMember(Name = "warWinStreak")]
        public int WarWinStreak { get; private set; }

        [DataMember(Name = "warWins")]
        public int WarWins { get; private set; }

        [DataMember(Name = "warTies")]
        public int WarTies { get; private set; }

        [DataMember(Name = "warLosses")]
        public int WarLosses { get; private set; }

        [DataMember(Name = "isWarLogPublic")]
        public bool IsWarLogPublic { get; private set; }

        [DataMember(Name = "members")]
        public int MemberCount { get; private set; }

        [DataMember(Name = "memberList")]
        public IEnumerable<ClanMember> Members { get; private set; }
    }
}
