using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Locations
{
    public class LocationsResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<Location> Locations { get; private set; }
    }
}
