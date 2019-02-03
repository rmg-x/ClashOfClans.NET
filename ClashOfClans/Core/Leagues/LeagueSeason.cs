using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeason : ILeagueSeason, IEquatable<LeagueSeason>
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        public bool Equals(LeagueSeason other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}
