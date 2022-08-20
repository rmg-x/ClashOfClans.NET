using System.Runtime.Serialization;

namespace ClashOfClans
{
    public enum ClanMemberRole
    {
        [EnumMember(Value = "leader")]
        Leader,
        [EnumMember(Value = "coLeader")]
        CoLeader,
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "member")]
        Member
    }
}
