using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Locations.Interfaces;

namespace ClashOfClans.Core.Interfaces
{
    public interface IClashOfClansClient
    {
        IClashClans Clans { get; }

        IClashLocations Locations { get; }
    }
}
