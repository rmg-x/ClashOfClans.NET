using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

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
