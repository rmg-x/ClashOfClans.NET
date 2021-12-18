using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMembersResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<ClanMember> Members { get; private set; }
    }
}
