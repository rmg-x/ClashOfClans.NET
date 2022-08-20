using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ILeagueGroup
    {
        WarState WarState { get; }

        string Season { get; }

        IEnumerable<LeagueGroupClan> Clans { get; }

        IEnumerable<LeagueGroupRound> Rounds { get; }
    }
}
