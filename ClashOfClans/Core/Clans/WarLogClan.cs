using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class WarLogClan : IWarLogClan
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [DataMember(Name = "clanLevel")]
        public int ClanLevel { get; private set; }

        [DataMember(Name = "attacks")]
        public int Attacks { get; private set; }

        [DataMember(Name = "stars")]
        public int Stars { get; private set; }

        [DataMember(Name = "destructionPercentage")]
        public double DestructionPercentage { get; private set; }

        [DataMember(Name = "expEarned")]
        public int ExpEarned { get; private set; }
    }
}
