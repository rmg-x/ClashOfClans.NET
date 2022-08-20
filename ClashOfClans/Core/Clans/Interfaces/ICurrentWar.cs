using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ICurrentWar
    {
        WarState WarState { get; }

        CurrentWarClan Clan { get; }

        CurrentWarClan Opponent { get; }
    }
}
