using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Leagues
{
    public class LeaguesResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<League> Leagues { get; private set; }
    }
}
