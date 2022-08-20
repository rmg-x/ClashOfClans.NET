using System;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWar
    {
        WarState WarState { get; }

        int TeamSize { get; }

        DateTime PreparationStartTime { get; }

        DateTime StartTime { get; }

        DateTime EndTime { get; }

        CurrentWarClan Clan { get; }

        CurrentWarClan Opponent { get; }
    }
}
