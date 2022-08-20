using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerAchievement : IClashPlayerAchievement, IEquatable<ClashPlayerAchievement>
    {
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("stars")]
        public int Stars { get; private set; }

        [JsonPropertyName("value")]
        public int Value { get; private set; }

        [JsonPropertyName("target")]
        public int Target { get; private set; }

        [JsonPropertyName("info")]
        public string Description { get; private set; }

        [JsonPropertyName("completionInfo")]
        public string CompletionInformation { get; private set; }

        [JsonPropertyName("village")]
        public string Village { get; private set; }

        public bool Equals(ClashPlayerAchievement other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
