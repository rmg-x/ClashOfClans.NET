using ClashOfClans.Core.Locations.Interfaces;
using ClashOfClans.Core.Utils;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Locations
{
    public class ClashLocations : IClashLocations
    {
        private readonly HttpClient _httpClient;

        public ClashLocations(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Location>> GetLocationsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<LocationsResult>("locations", ClashConstants.DefaultJsonSerializerOptions);

            return result.Locations;
        }

        /// <inheritdoc />
        public async Task<Location> GetLocationByIdAsync(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Location>($"locations/{id}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }
    }
}
