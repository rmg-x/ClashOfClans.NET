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

        [DataMember(Name = "teamSize")]
        public int TeamSize { get; private set; }

        [DataMember(Name = "preparationStartTime")]
        public string PreparationStartTime { get; private set; }

        [DataMember(Name = "startTime")]
        public string StartTime { get; private set; }

        [DataMember(Name = "endTime")]
        public string EndTime { get; private set; }

        [DataMember(Name = "clan")]
        public CurrentWarClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public CurrentWarClan Opponent { get; private set; }
    }
}
