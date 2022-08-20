using System;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IWarLog
    {
        WarResult Result { get; }

        DateTime EndTime { get; }

        int TeamSize { get; }

        WarLogClan Clan { get; }

        WarLogOpponent Opponent { get; }
    }
}
