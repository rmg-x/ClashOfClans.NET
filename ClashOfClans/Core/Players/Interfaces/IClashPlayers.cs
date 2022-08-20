using System.Threading.Tasks;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayers
    {
        /// <summary>
        /// Gets a player based off the given tag
        /// </summary>
        /// <param name="playerTag">Player tag</param>
        /// <returns><see cref="ClashPlayer"/></returns>
        Task<ClashPlayer> GetPlayerByTagAsync(string playerTag);

        /// <summary>
        /// Verify player API token that can be found from the game settings
        /// </summary>
        /// <param name="playerTag">Player tag</param>
        /// <param name="apiToken">API token</param>
        /// <returns><see langword="true" /> if token is valid, else <see langword="false" /></returns>
        Task<bool> VerifyApiToken(string playerTag, string apiToken);
    }
}
