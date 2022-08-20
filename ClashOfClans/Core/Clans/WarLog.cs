using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Runtime.Serialization;
using Utf8Json;
using Utf8Json.Formatters;

namespace ClashOfClans.Core.Clans
{
    public class WarLog : IWarLog, IEquatable<WarLog>
    {
        [DataMember(Name = "result")]
        public WarResult Result { get; private set; }

        [DataMember(Name = "endTime")]
        [JsonFormatter(typeof(DateTimeFormatter), ClashConstants.CLASH_DATE_FORMAT)]
        public DateTime EndTime { get; private set; }

        [DataMember(Name = "teamSize")]
        public int TeamSize { get; private set; }

        [DataMember(Name = "clan")]
        public WarLogClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public WarLogOpponent Opponent { get; private set; }

        public bool Equals(WarLog other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag 
                && Opponent.Tag == other.Opponent.Tag
                && EndTime == other.EndTime;
        }
    }
}
