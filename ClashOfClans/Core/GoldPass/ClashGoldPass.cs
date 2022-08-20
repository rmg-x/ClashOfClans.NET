using ClashOfClans.Core.GoldPass;
using ClashOfClans.Core.GoldPass.Interfaces;
using ClashOfClans.Core.Utils;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Goldpass
{
    public class ClashGoldPass : IClashGoldPass
    {
        private readonly HttpClient _httpClient;

        public ClashGoldPass(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc />
        public async Task<GoldPassInformation> GetCurrentGoldPassAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<GoldPassInformation>("goldpass/seasons/current", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }
    }
}
