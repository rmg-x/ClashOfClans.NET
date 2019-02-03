using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerAchievement : IClashPlayerAchievement, IEquatable<ClashPlayerAchievement>
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "stars")]
        public int Stars { get; private set; }

        [DataMember(Name = "value")]
        public int Value { get; private set; }

        [DataMember(Name = "target")]
        public int Target { get; private set; }

        [DataMember(Name = "info")]
        public string Description { get; private set; }

        [DataMember(Name = "completionInfo")]
        public string CompletionInformation { get; private set; }

        [DataMember(Name = "village")]
        public string Village { get; private set; }

        public bool Equals(ClashPlayerAchievement other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
