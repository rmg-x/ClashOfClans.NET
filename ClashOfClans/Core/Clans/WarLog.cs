using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLog : IWarLog, IEquatable<WarLog>
    {
        [JsonPropertyName("result")]
        public WarResult Result { get; private set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; private set; }

        [JsonPropertyName("teamSize")]
        public int TeamSize { get; private set; }

        [JsonPropertyName("clan")]
        public WarLogClan Clan { get; private set; }

        [JsonPropertyName("opponent")]
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
