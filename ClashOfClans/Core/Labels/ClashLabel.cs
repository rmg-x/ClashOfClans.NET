using ClashOfClans.Core.Labels.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Labels
{
    public class ClashLabel : IClashLabel, IEquatable<ClashLabel>
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("iconUrls")]
        public LabelBadges Icons { get; set; }

        public bool Equals(ClashLabel other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }
    }
}
