using System.Threading.Tasks;

namespace ClashOfClans.Core.GoldPass.Interfaces
{
    public interface IClashGoldPass
    {
        /// <summary>
        /// Get information about the current gold pass season
        /// </summary>
        /// <returns><see cref="GoldPassInformation" /></returns>
        Task<GoldPassInformation> GetCurrentGoldPassAsync();
    }
}
