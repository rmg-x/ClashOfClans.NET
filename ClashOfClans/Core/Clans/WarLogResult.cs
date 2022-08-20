using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Clans
{
    public class WarLogResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<WarLog> WarLogs { get; set; }
    }
}
