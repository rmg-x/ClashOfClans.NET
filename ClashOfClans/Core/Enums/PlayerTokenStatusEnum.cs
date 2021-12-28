using System.Runtime.Serialization;

namespace ClashOfClans
{
    public enum PlayerTokenStatus
    {
        [EnumMember(Value = "ok")]
        Ok,
        [EnumMember(Value = "invalid")]
        Invalid
    }
}
