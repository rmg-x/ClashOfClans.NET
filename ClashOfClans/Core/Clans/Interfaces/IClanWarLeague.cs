using System;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanWarLeague : ICurrentWar
    {
        DateTime WarStartTime { get; }
    }
}
