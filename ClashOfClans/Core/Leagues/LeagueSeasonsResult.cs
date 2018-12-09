using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeasonsResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<LeagueSeason> LeagueSeasons { get; private set; }
    }
}
