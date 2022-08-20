using ClashOfClans.Core.Locations.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Locations
{
    public class Location : ILocation, IEquatable<Location>
    {
        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("isCountry")]
        public bool IsCountry { get; private set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; private set; }

        public bool Equals(Location other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}
