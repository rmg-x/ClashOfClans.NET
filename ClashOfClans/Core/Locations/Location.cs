using ClashOfClans.Core.Locations.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Locations
{
    public class Location : ILocation
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "isCountry")]
        public bool IsCountry { get; private set; }

        [DataMember(Name = "countryCode")]
        public string CountryCode { get; private set; }
    }
}
