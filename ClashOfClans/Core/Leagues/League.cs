using ClashOfClans.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Leagues
{
    public class League : ILeague
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "iconUrls")]
        public LeagueIcons Icons { get; private set; }

        public override string ToString() => Name;
    }
}
