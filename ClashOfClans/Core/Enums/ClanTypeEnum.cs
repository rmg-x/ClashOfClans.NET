using System.Runtime.Serialization;

namespace ClashOfClans
{
    public enum ClanType
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "inviteOnly")]
        InviteOnly
    }
}
