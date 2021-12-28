using ClashOfClans.Core.Players.Interfaces;
using ClashOfClans.Core.Utils;
using System.Net.Http;
using System.Net.Http.Json;
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
    }
}
