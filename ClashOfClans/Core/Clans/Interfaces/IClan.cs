namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface IClan
    {
        string Tag { get; }

        string Name { get; }

        ClanLocation Location { get; }

        ClanBadges Badges { get; }

        int ClanLevel { get; }

        int ClanPoints { get; }

        int ClanVersusPoints { get; }

        int MemberCount { get; }
    }
}
