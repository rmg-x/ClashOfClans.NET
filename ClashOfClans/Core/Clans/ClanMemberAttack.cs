using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMemberAttack : IClanMemberAttack, IEquatable<ClanMemberAttack>
    {
        [JsonPropertyName("attackerTag")]
        public string AttackerTag { get; private set; }

        [JsonPropertyName("defenderTag")]
        public string DefenderTag { get; private set; }

        [JsonPropertyName("stars")]
        public int Stars { get; private set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; private set; }

        [JsonPropertyName("order")]
        public int Order { get; private set; }

        public bool Equals(ClanMemberAttack other)
        {
            if (other == null)
                return false;

            return AttackerTag == other.AttackerTag;
        }
    }
}
