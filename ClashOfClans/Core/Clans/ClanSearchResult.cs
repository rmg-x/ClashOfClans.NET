using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class ClanSearchResult : IClanSearchResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<Clan> Clans { get; private set; }
    }
}
