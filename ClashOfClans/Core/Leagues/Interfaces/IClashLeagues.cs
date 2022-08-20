using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Leagues.Interfaces
{
    public interface IClashLeagues
    {
        Task<IEnumerable<League>> GetLeaguesAsync();
    }
}
