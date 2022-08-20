using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class League : ILeague, IEquatable<League>
    {
        [DataMember(Name = "id")]
        public int Id { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "iconUrls")]
        public LeagueIcons Icons { get; private set; }

        public bool Equals(League other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }

        public override string ToString() => Name;
    }
}
