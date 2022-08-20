using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeason : ILeagueSeason
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }
    }
}
