using ClashOfClans.Core.Players.Interfaces;
using ClashOfClans.Core.Utils;
using System.Threading.Tasks;
using System.Web;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayers : IClashPlayers
    {
        private HttpClientService _httpClientService { get; set; }

        public ClashPlayers(HttpClientService httpClientService) => _httpClientService = httpClientService;

        /// <summary>
        /// Gets a player based off the given tag
        /// </summary>
        /// <param name="playerTag">Player tag</param>
        /// <returns><see cref="ClashPlayer"/></returns>
        public async Task<ClashPlayer> GetPlayerByTagAsync(string playerTag)
        {
            var result = await _httpClientService.RequestAsync<ClashPlayer>($"players/{HttpUtility.UrlEncode(playerTag)}");

            return result;
        }
    }
}
