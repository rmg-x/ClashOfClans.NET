﻿using ClashOfClans.Core.Clans.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class WarLogOpponent : IWarLogOpponent, IEquatable<WarLogOpponent>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("badgeUrls")]
        public ClanBadges Badges { get; private set; }

        [JsonPropertyName("clanLevel")]
        public int ClanLevel { get; private set; }

        [JsonPropertyName("stars")]
        public int Stars { get; private set; }

        [JsonPropertyName("destructionPercentage")]
        public double DestructionPercentage { get; private set; }

        public bool Equals(WarLogOpponent other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
