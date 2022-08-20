using ClashOfClans.Core.Clans;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface ILeagueSeasonClan
    {
        string Tag { get; }

        string Name { get; }

        ClanBadges Badges { get; }
    }
}
