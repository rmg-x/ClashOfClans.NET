namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClan
    {
        string Tag { get; }

        string Name { get; }

        ClanType Type { get; }

        ClanLocation Location { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int ClanPoints { get; }

        int ClanVersusPoints { get; }

        int RequiredTrophies { get; }

        WarFrequency WarFrequency { get; }

        int WarWinStreak { get; }

        int WarWins { get; }

        bool IsWarLogPublic { get; }

        int MemberCount { get; }
    }
}
