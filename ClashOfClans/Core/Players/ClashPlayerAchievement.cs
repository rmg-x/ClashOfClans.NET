using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ClashOfClans.Core.Players
{
    public class ClashPlayerAchievement : IClashPlayerAchievement
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
    }
}
