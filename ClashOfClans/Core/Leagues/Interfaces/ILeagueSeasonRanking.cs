using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface ILeagueSeasonRanking
    {
        string Tag { get; }

        string Name { get; }

        int ExpLevel { get; }

        int Trophies { get; }

        int AttackWins { get; }

        int DefenseWins { get; }

        int Rank { get; }

        LeagueSeasonClan Clan { get; }
    }
}
