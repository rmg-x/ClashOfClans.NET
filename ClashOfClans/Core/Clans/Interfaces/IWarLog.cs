using ClashOfClans.Core.Clans;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IWarLog
    {
        WarResult Result { get; }

        string EndTime { get; }

        int TeamSize { get; }

        WarLogClan Clan { get; }

        WarLogOpponent Opponent { get; }
    }
}
