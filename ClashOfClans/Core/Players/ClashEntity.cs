using ClashOfClans.Core.Players.Interfaces;
using System;
using System.Runtime.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashEntity : IClashEntity, IEquatable<ClashEntity>
    {
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        [DataMember(Name = "level")]
        public int Level { get; private set; }

        [DataMember(Name = "maxLevel")]
        public int MaxLevel { get; private set; }

        [DataMember(Name = "village")]
        public EntityVillage Village { get; private set; }

        public bool Equals(ClashEntity other)
        {
            if (other == null)
                return false;

            return Name == other.Name;
        }
    }
}
