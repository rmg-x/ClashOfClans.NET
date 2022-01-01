using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Labels.Interfaces
{
    public interface IClashLabels
    {
        /// <summary>
        /// Get a list of player labels
        /// </summary>
        /// <returns><see cref="IEnumerable{ClashLabel}"/></returns>
        Task<IEnumerable<ClashLabel>> GetPlayerLabelsAsync();

        /// <summary>
        /// Get a list of clan labels
        /// </summary>
        /// <returns><see cref="IEnumerable{ClashLabel}"/></returns>
        Task<IEnumerable<ClashLabel>> GetClanLabelsAsync();
    }
}
