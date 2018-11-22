using System.Runtime.Serialization;

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
