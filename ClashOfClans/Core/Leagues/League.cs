﻿using ClashOfClans.Core.Leagues.Interfaces;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Leagues
{
    public class League : ILeague, IEquatable<League>
    {
        [JsonPropertyName("id")]
        public int Id { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("iconUrls")]
        public LeagueIcons Icons { get; private set; }

        public bool Equals(League other)
        {
            if (other == null)
                return false;

            return Id == other.Id;
        }

        public override string ToString() => Name;
    }
}
