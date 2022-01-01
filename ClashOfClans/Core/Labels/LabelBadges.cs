using ClashOfClans.Core.Labels.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Labels
{
    public class LabelBadges : ILabelBadges, IEquatable<LabelBadges>
    {
        [JsonPropertyName("small")]
        public string Small { get; set; }

        [JsonPropertyName("medium")]
        public string Medium { get; set; }

        [JsonPropertyName("large")]
        public string Large { get; set; }

        public bool Equals(LabelBadges other)
        {
            if (other == null)
                return false;

            return Small == other.Small
                && Medium == other.Medium
                && Large == other.Large;
        }
    }
}
