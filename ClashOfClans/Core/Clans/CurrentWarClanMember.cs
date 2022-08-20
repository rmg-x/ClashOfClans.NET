using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWarClanMember : ICurrentWarClanMember, IEquatable<CurrentWarClanMember>
    {
        [DataMember(Name = "tag")]
        public string Tag { get; private set; }

        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "townhallLevel")]
        public int TownhallLevel { get; private set; }

        [DataMember(Name = "mapPosition")]
        public int MapPosition { get; private set; }

        [DataMember(Name = "attacks")]
        public IEnumerable<ClanMemberAttack> Attacks { get; private set; }

        [DataMember(Name = "opponentAttacks")]
        public int OpponentAttackCount { get; private set; }

        [DataMember(Name = "bestOpponentAttack")]
        public ClanMemberAttack BestOpponentAttack { get; private set; }

        public bool Equals(CurrentWarClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
