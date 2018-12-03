using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWar : ICurrentWar
    {
        [DataMember(Name = "state")]
        public WarState WarState { get; private set; }

        [DataMember(Name = "clan")]
        public CurrentWarClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public CurrentWarClan Opponent { get; private set; }
    }
}
