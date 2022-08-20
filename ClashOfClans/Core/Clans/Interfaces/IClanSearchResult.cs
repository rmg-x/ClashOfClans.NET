using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanSearchResult
    {
        IEnumerable<Clan> Clans { get; }
    }
}
