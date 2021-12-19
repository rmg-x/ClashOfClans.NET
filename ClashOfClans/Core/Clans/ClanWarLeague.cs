using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanWarLeague : IClanWarLeague, IEquatable<ClanWarLeague>
    {
        [JsonPropertyName("warStartTime")]
        public DateTime WarStartTime { get; set; }

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

        public bool Equals(ClanWarLeague other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag;
        }
    }
}
