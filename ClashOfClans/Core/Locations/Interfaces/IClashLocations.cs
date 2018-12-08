using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Locations.Interfaces
{
    public interface IClashLocations
    {
        Task<IEnumerable<Location>> GetLocationsAsync();

        Task<Location> GetLocationByIdAsync(int id);
    }
}
