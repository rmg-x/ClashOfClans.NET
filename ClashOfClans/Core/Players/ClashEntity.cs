using ClashOfClans.Core.Players.Interfaces;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashEntity : IClashEntity
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "level")]
        public int Level { get; private set; }

        [DataMember(Name = "maxLevel")]
        public int MaxLevel { get; private set; }

        [DataMember(Name = "village")]
        public EntityVillage Village { get; private set; }
    }
}
