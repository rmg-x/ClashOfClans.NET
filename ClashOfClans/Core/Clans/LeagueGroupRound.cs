using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class LeagueGroupRound : ILeagueGroupRound, IEquatable<LeagueGroupRound>
    {
        [JsonPropertyName("warTags")]
        public IEnumerable<string> WarTags { get; set; }

        public bool Equals(LeagueGroupRound other)
        {
            if (other == null)
                return false;

            return WarTags == other.WarTags;
        }
    }
}
