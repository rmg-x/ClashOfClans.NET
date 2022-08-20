using ClashOfClans.Core.Leagues;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface ILeague
    {
        int Id { get; }

        string Name { get; }

        LeagueIcons Icons { get; }
    }
}
