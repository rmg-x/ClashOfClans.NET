using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWar : ICurrentWar, IEquatable<CurrentWar>
    {
        [JsonPropertyName("state")]
        public WarState WarState { get; private set; }

        [JsonPropertyName("teamSize")]
        public int TeamSize { get; private set; }

        [JsonPropertyName("preparationStartTime")]
        public DateTime PreparationStartTime { get; private set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; private set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; private set; }

        [JsonPropertyName("clan")]
        public CurrentWarClan Clan { get; private set; }

        [JsonPropertyName("opponent")]
        public CurrentWarClan Opponent { get; private set; }

        public bool Equals(CurrentWar other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag;
        }
    }
}
