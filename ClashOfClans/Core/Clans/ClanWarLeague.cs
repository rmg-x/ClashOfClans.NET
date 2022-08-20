using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Utils;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanWarLeague : IClanWarLeague, IEquatable<ClanWarLeague>
    {
        [DataMember(Name = "warStartTime")]
        public DateTime WarStartTime { get; private set; }

        [DataMember(Name = "state")]
        public WarState WarState { get; private set; }

        [DataMember(Name = "teamSize")]
        public int TeamSize { get; private set; }

        [DataMember(Name = "preparationStartTime")]
        public DateTime PreparationStartTime { get; private set; }

        [DataMember(Name = "startTime")]
        public DateTime StartTime { get; private set; }

        [DataMember(Name = "endTime")]
        public DateTime EndTime { get; private set; }

        [DataMember(Name = "clan")]
        public CurrentWarClan Clan { get; private set; }

        [DataMember(Name = "opponent")]
        public CurrentWarClan Opponent { get; private set; }

        public bool Equals(ClanWarLeague other)
        {
            if (other == null)
                return false;

            return Clan.Tag == other.Clan.Tag;
        }
    }
}
