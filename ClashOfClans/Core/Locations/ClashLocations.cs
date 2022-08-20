using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Locations
{
    public class ClashLocations : IClashLocations
    {
        private HttpClientService _httpClientService { get; set; }

        public ClashLocations(HttpClientService httpClientService) => _httpClientService = httpClientService;

        /// <summary>
        /// Gets all available locations.
        /// </summary>
        /// <returns><see cref="IEnumerable{Location}"/></returns>
        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            var result = await _httpClientService.RequestAsync<LocationsResult>("locations");

            return result.Locations;
        }

        /// <summary>
        /// Get a location by its ID
        /// </summary>
        /// <param name="id">Location id to get</param>
        /// <returns><see cref="Location"/></returns>
        public async Task<Location> GetLocationByIdAsync(int id)
        {
            var result = await _httpClientService.RequestAsync<Location>($"locations/{id}");

            return result;
        }
    }
}
