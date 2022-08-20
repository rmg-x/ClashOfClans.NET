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
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("townhallLevel")]
        public int TownhallLevel { get; set; }

        [JsonPropertyName("mapPosition")]
        public int MapPosition { get; set; }

        [JsonPropertyName("attacks")]
        public IEnumerable<ClanMemberAttack> Attacks { get; set; }

        [JsonPropertyName("opponentAttacks")]
        public int OpponentAttackCount { get; set; }

        [JsonPropertyName("bestOpponentAttack")]
        public ClanMemberAttack BestOpponentAttack { get; set; }

        public bool Equals(CurrentWarClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
