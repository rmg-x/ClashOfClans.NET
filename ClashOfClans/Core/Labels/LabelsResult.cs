using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Labels
{
    public class LabelsResult
    {
        [JsonPropertyName("items")]
        public IEnumerable<ClashLabel> Labels { get; set; }
    }
}
