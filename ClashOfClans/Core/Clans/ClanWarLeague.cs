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
        public DateTime WarStartTime { get; private set; }

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

        public bool Equals(ClanWarLeague other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag;
        }
    }
}
