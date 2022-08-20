using ClashOfClans.Core.Clans.Interfaces;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanSearchResult : IClanSearchResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<Clan> Clans { get; private set; }
    }
}
