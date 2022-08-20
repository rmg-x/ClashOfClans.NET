using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans
{
    public enum WarResult
    {
        [EnumMember(Value = "win")]
        Win,
        [EnumMember(Value = "lose")]
        Loss
    }
}
