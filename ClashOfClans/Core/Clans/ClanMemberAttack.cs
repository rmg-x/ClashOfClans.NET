using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMemberAttack : IClanMemberAttack, IEquatable<ClanMemberAttack>
    {
        [JsonPropertyName("attackerTag")]
        public string AttackerTag { get; set; }

        [JsonPropertyName("defenderTag")]
        public string DefenderTag { get; set; }

        [JsonPropertyName("stars")]
        public int Stars { get; set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; set; }

        [JsonPropertyName("order")]
        public int Order { get; set; }

        public bool Equals(ClanMemberAttack other)
        {
            if (other == null)
                return false;

            return AttackerTag == other.AttackerTag;
        }
    }
}
