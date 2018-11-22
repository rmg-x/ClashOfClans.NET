using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogResult
    {
        [DataMember(Name = "items")]
        public IEnumerable<WarLog> WarLogs { get; set; }
    }
}
