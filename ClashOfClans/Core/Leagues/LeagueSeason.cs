using ClashOfClans.Core.Leagues.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class LeagueSeason : ILeagueSeason
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }
    }
}
