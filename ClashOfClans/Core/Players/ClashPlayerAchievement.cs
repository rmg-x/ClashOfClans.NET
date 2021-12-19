using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerAchievement : IClashPlayerAchievement, IEquatable<ClashPlayerAchievement>
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("stars")]
        public int Stars { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }

        [JsonPropertyName("target")]
        public int Target { get; set; }

        [JsonPropertyName("info")]
        public string Description { get; set; }

        [JsonPropertyName("completionInfo")]
        public string CompletionInformation { get; set; }

        [JsonPropertyName("village")]
        public string Village { get; set; }

        public bool Equals(ClashPlayerAchievement other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
