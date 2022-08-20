using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWarClanMember : ICurrentWarClanMember
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
    }
}
