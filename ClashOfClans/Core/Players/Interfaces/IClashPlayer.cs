using ClashOfClans.Core.Leagues;
using System.Collections.Generic;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayer
    {
        string Tag { get; }

        string Name { get; }

        int TownhallLevel { get; }

        int ExpLevel { get; }

        int Trophies { get; }

        int BestTrophies { get; }

        int WarStars { get; }

        int AttackWins { get; }

        int DefenseWins { get; }

        int BuliderHallLevel { get; }

        int VersusTrophies { get; }

        int BestVersusTrophies { get; }

        int VersusBattleWins { get; }

        ClanMemberRole Role { get; }

        int Donations { get; }

        int DonationsReceived { get; }

        ClashPlayerClan Clan { get; }

        League League { get; }

        IEnumerable<ClashPlayerAchievement> Achievements { get; }

        int VersusBattleWinCount { get; }

        IEnumerable<ClashEntity> Troops { get; }

        IEnumerable<ClashEntity> Heroes { get; }

        IEnumerable<ClashEntity> Spells { get; }
    }
}
