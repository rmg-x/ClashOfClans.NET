using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWar : ICurrentWar, IEquatable<CurrentWar>
    {
        [JsonPropertyName("state")]
        public WarState WarState { get; set; }

        [JsonPropertyName("teamSize")]
        public int TeamSize { get; set; }

        [JsonPropertyName("preparationStartTime")]
        public DateTime PreparationStartTime { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("clan")]
        public CurrentWarClan Clan { get; set; }

        [JsonPropertyName("opponent")]
        public CurrentWarClan Opponent { get; set; }

        public bool Equals(CurrentWar other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag;
        }
    }
}
