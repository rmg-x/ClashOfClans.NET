using System;
using System.Collections.Generic;
using System.Text;

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
