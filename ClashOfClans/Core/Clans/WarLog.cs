using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Utf8Json;
using Utf8Json.Formatters;

namespace ClashOfClans.Core.Clans
{
    public class WarLog : IWarLog
    {
        [DataMember(Name = "result")]
        public WarResult Result { get; private set; }

        [DataMember(Name = "endTime")]
        public string EndTime { get; private set; }

        [DataMember(Name = "teamSize")]
        public int TeamSize { get; private set; }

        [DataMember(Name = "clan")]
        public WarLogClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public WarLogOpponent Opponent { get; private set; }
    }
}
