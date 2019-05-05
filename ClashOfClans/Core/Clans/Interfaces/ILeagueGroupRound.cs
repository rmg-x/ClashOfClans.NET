using System;
using System.Collections.Generic;
using System.Text;

namespace ClashOfClans.Core.Clans.Interfaces
{
    public interface ILeagueGroupRound
    {
        IEnumerable<string> WarTags { get; }
    }
}
