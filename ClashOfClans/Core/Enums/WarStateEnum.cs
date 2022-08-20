using System.Runtime.Serialization;

namespace ClashOfClans
{
    public enum WarState
    {
        [EnumMember(Value = "inWar")]
        InWar,
        [EnumMember(Value = "notInWar")]
        NotInWar,
        [EnumMember(Value = "preparation")]
        Preparation
    }
}
