using ClashOfClans.Core.Interfaces;
using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueIcons : ILeagueIcons
    {
        [DataMember(Name = "small")]
        public string Small { get; private set; }

        [DataMember(Name = "tiny")]
        public string Tiny { get; private set; }

        [DataMember(Name = "medium")]
        public string Medium { get; private set; }
    }
}
