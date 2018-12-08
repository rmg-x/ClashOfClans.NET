using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class ClanMemberAttack : IClanMemberAttack
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
    }
}
