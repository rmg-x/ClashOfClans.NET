using System.Threading.Tasks;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayers
    {
        Task<ClashPlayer> GetPlayerByTagAsync(string playerTag);

        Task<bool> VerifyApiToken(string playerTag, string apiToken);
    }
}
