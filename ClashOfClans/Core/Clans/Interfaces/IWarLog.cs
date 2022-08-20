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
