using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeason : ILeagueSeason, IEquatable<LeagueSeason>
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public bool Equals(LeagueSeason other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}
