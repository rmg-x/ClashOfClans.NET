using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Leagues;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMember : IClanMember
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "role")]
        public ClanMemberRole Role { get; private set; }

        [DataMember(Name = "expLevel")]
        public int ExpLevel { get; private set; }

        [DataMember(Name = "league")]
        public League League { get; private set; }

        [DataMember(Name = "trophies")]
        public int Trophies { get; private set; }

        [DataMember(Name = "versusTrophies")]
        public int VersusTrophies { get; private set; }

        [DataMember(Name = "clanRank")]
        public int ClanRank { get; private set; }

        [DataMember(Name = "previousClanRank")]
        public int PreviousClanRank { get; private set; }

        [DataMember(Name = "donations")]
        public int Donations { get; private set; }

        [DataMember(Name = "donationsRecieved")]
        public int DonationsRecieved { get; private set; }
    }
}
