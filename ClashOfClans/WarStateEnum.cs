using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans
{
    public enum WarState
    {
        [EnumMember(Value = "inWar")]
        InWar,
        [EnumMember(Value = "notInWar")]
        NotInWar
    }
}
