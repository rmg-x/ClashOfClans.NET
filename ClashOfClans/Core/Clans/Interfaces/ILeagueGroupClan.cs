using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ILeagueGroupClan
    {
        string Tag { get; }

        string Name { get; }

        int ClanLevel { get; }

        ClanBadges Badges { get; }

        IEnumerable<LeagueGroupClanMember> Members { get; }
    }
}
