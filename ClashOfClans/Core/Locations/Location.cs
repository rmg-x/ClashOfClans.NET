using ClashOfClans.Core.Locations.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Locations
{
    public class Location : ILocation, IEquatable<Location>
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isCountry")]
        public bool IsCountry { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        public bool Equals(Location other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}
