using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ILeagueGroupRound
    {
        IEnumerable<string> WarTags { get; }
    }
}
