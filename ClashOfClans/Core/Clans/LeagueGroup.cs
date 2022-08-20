using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroup : ILeagueGroup, IEquatable<LeagueGroup>
    {
        [JsonPropertyName("state")]
        public WarState WarState { get; set; }

        [JsonPropertyName("season")]
        public string Season { get; set; }

        [JsonPropertyName("clans")]
        public IEnumerable<LeagueGroupClan> Clans { get; set; }

        [JsonPropertyName("rounds")]
        public IEnumerable<LeagueGroupRound> Rounds { get; set; }

        public bool Equals(LeagueGroup other)
        {
            if (other == null)
                return false;

            return WarState == other.WarState
                && Season == other.Season;
        }
    }
}
