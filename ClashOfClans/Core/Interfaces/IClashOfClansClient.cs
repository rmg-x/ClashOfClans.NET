using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Players.Interfaces;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClashOfClansClient
    {
        IClashClans Clans { get; }

        IClashLocations Locations { get; }

        IClashLeagues Leagues { get; }

        IClashPlayers Players { get; }
    }
}
