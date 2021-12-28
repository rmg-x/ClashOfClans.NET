using ClashOfClans.Core.Players.Interfaces;
using ClashOfClans.Core.Utils;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayers : IClashPlayers
    {
        private readonly HttpClient _httpClient;

        public ClashPlayers(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets a player based off the given tag
        /// </summary>
        /// <param name="playerTag">Player tag</param>
        /// <returns><see cref="ClashPlayer"/></returns>
        public async Task<ClashPlayer> GetPlayerByTagAsync(string playerTag)
        {
            var result = await _httpClient.GetFromJsonAsync<ClashPlayer>($"players/{HttpUtility.UrlEncode(playerTag)}", ClashConstants.DefaultJsonSerializerOptions);

            return result;
        }

        /// <summary>
        /// Verify player API token that can be found from the game settings
        /// </summary>
        /// <param name="playerTag">Player tag</param>
        /// <param name="apiToken">API token</param>
        /// <returns><see langword="true" /> if token is valid, else <see langword="false" /></returns>
        public async Task<bool> VerifyApiToken(string playerTag, string apiToken)
        {
            var requestBody = new
            {
                token = apiToken
            };

            string requestUri = $"players/{HttpUtility.UrlEncode(playerTag)}/verifytoken";

            var result = await _httpClient.PostAsJsonAsync(requestUri, requestBody, ClashConstants.DefaultJsonSerializerOptions);

            result.EnsureSuccessStatusCode();

            var responseBody = await result.Content.ReadAsStreamAsync();

            var tokenVerification = await JsonSerializer.DeserializeAsync<ClashTokenVerification>(responseBody, ClashConstants.DefaultJsonSerializerOptions);

            return tokenVerification.Status == PlayerTokenStatus.Ok;
        }
    }
}
