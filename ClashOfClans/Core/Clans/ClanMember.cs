using ClashOfClans.Core.Clans.Interfaces;
using ClashOfClans.Core.Leagues;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Clans
{
    public class ClanMember : IClanMember, IEquatable<ClanMember>
    {
        [JsonPropertyName("tag")]
        public string Tag { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        [JsonPropertyName("role")]
        public ClanMemberRole Role { get; private set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; private set; }

        [JsonPropertyName("league")]
        public League League { get; private set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; private set; }

        [JsonPropertyName("versusTrophies")]
        public int VersusTrophies { get; private set; }

        [JsonPropertyName("clanRank")]
        public int ClanRank { get; private set; }

        [JsonPropertyName("previousClanRank")]
        public int PreviousClanRank { get; private set; }

        [JsonPropertyName("donations")]
        public int Donations { get; private set; }

        [JsonPropertyName("donationsRecieved")]
        public int DonationsRecieved { get; private set; }

        public bool Equals(ClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
