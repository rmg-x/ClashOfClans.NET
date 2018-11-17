using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class ClanLocation : IClanLocation
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "isCountry")]
        public bool IsCountry { get; private set; }
    }
}
