using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanWarLeague : ICurrentWar
    {
        DateTime WarStartTime { get; }
    }
}
