using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroup : ILeagueGroup, IEquatable<LeagueGroup>
    {
        [JsonPropertyName("state")]
        public WarState WarState { get; private set; }

        [JsonPropertyName("season")]
        public string Season { get; private set; }

        [JsonPropertyName("clans")]
        public IEnumerable<LeagueGroupClan> Clans { get; private set; }

        [JsonPropertyName("rounds")]
        public IEnumerable<LeagueGroupRound> Rounds { get; private set; }

        public bool Equals(LeagueGroup other)
        {
            if (other == null)
                return false;

            return WarState == other.WarState
                && Season == other.Season;
        }
    }
}
