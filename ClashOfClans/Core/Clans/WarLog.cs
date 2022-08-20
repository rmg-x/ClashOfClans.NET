using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLog : IWarLog, IEquatable<WarLog>
    {
        [JsonPropertyName("result")]
        public WarResult Result { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("teamSize")]
        public int TeamSize { get; set; }

        [JsonPropertyName("clan")]
        public WarLogClan Clan { get; set; }

        [JsonPropertyName("opponent")]
        public WarLogOpponent Opponent { get; set; }

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
