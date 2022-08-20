using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class ClanMembersResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<ClanMember> Members { get; private set; }
    }
}
