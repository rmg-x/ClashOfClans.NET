using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Locations
{
    public class LocationsResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<Location> Locations { get; private set; }
    }
}
