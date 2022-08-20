using ClashOfClans.Core.Clans;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayerClan
    {
        string Tag { get; }

        string Name { get; }

        int ClanLevel { get; }

        ClanBadges Badges { get; }
    }
}
