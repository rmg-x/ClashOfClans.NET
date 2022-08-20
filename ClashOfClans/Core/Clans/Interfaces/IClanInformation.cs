using ClashOfClans.Core.Locations;
using System.Collections.Generic;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClanInformation
    {
        string Tag { get; }

        string Name { get; }

        ClanType Type { get; }

        string Description { get; }

        Location Location { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int ClanPoints { get; }

        int ClanVersusPoints { get; }

        int RequiredTrophies { get; }

        WarFrequency WarFrequency { get; }

        int WarWinStreak { get; }

        int WarWins { get; }

        int WarTies { get; }

        int WarLosses { get; }

        bool IsWarLogPublic { get; }

        int MemberCount { get; }

        IEnumerable<ClanMember> Members { get; }
    }
}
