using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClanSearchResult
    {
        IEnumerable<Clan> Clans { get; }
    }
}
