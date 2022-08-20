using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashEntity : IClashEntity, IEquatable<ClashEntity>
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("level")]
        public int Level { get; private set; }

        [JsonPropertyName("maxLevel")]
        public int MaxLevel { get; private set; }

        [JsonPropertyName("village")]
        public EntityVillage Village { get; private set; }

        public bool Equals(ClashEntity other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
