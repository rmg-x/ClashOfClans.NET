using System.Threading.Tasks;

namespace ClashOfClans.Core.Players.Interfaces
{
    public interface IClashPlayers
    {
        Task<ClashPlayer> GetPlayerByTagAsync(string playerTag);
    }
}
