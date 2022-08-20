using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.GoldPass.Interfaces;
using ClashOfClans.Core.Labels.Interfaces;
using ClashOfClans.Core.Leagues.Interfaces;
using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Players.Interfaces;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClashOfClansClient
    {
        IClashClans Clans { get; }

        IClashLocations Locations { get; }

        IClashGoldPass GoldPass { get; }

        IClashLeagues Leagues { get; }

        IClashPlayers Players { get; }

        IClashLabels Labels { get; }
    }
}
