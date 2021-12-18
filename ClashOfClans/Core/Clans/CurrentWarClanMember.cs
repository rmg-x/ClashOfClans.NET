using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class CurrentWarClanMember : ICurrentWarClanMember, IEquatable<CurrentWarClanMember>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("townhallLevel")]
        public int TownhallLevel { get; private set; }

        [JsonPropertyName("mapPosition")]
        public int MapPosition { get; private set; }

        [JsonPropertyName("attacks")]
        public IEnumerable<ClanMemberAttack> Attacks { get; private set; }

        [JsonPropertyName("opponentAttacks")]
        public int OpponentAttackCount { get; private set; }

        [JsonPropertyName("bestOpponentAttack")]
        public ClanMemberAttack BestOpponentAttack { get; private set; }

        public bool Equals(CurrentWarClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
