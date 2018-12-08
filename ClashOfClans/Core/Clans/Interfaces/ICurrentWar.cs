using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWar
    {
        WarState WarState { get; }

        int TeamSize { get; }

        string PreparationStartTime { get; }

        string StartTime { get; }

        string EndTime { get; }

        CurrentWarClan Clan { get; }

        CurrentWarClan Opponent { get; }
    }
}
