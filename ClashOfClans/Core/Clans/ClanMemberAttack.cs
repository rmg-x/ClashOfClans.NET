using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMemberAttack : IClanMemberAttack, IEquatable<ClanMemberAttack>
    {
        [DataMember(Name = "attackerTag")]
        public string AttackerTag { get; private set; }

        [DataMember(Name = "defenderTag")]
        public string DefenderTag { get; private set; }

        [DataMember(Name = "stars")]
        public int Stars { get; private set; }

        [DataMember(Name = "destructionPercentage")]
        public double DestructionPercentage { get; private set; }

        [DataMember(Name = "order")]
        public int Order { get; private set; }

        public bool Equals(ClanMemberAttack other)
        {
            if (other == null)
                return false;

            return AttackerTag == other.AttackerTag;
        }
    }
}
