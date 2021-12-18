using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<WarLog> WarLogs { get; set; }
    }
}
