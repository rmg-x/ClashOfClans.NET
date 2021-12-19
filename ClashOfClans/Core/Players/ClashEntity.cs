using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashEntity : IClashEntity, IEquatable<ClashEntity>
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; set; }

        [JsonPropertyName("village")]
        public EntityVillage Village { get; set; }

        public bool Equals(ClashEntity other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
