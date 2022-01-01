using ClashOfClans.Core.Labels.Interfaces;
using ClashOfClans.Core.Utils;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Labels
{
    public class ClashLabels : IClashLabels
    {
        private readonly HttpClient _httpClient;

        public ClashLabels(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ClashLabel>> GetPlayerLabelsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<LabelsResult>("labels/players", ClashConstants.DefaultJsonSerializerOptions);

            return result.Labels;
        }

        public async Task<IEnumerable<ClashLabel>> GetClanLabelsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<LabelsResult>("labels/clans", ClashConstants.DefaultJsonSerializerOptions);

            return result.Labels;
        }
    }
}
