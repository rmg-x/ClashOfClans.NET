using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Locations.Interfaces
{
    public interface IClashLocations
    {
        /// <summary>
        /// Gets all available locations.
        /// </summary>
        /// <returns><see cref="IEnumerable{Location}"/></returns>
        Task<IEnumerable<Location>> GetLocationsAsync();

        /// <summary>
        /// Get a location by its ID
        /// </summary>
        /// <param name="id">Location id to get</param>
        /// <returns><see cref="Location"/></returns>
        Task<Location> GetLocationByIdAsync(int id);
    }
}
