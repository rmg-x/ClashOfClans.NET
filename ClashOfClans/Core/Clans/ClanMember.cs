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
        public string Tag { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("role")]
        public ClanMemberRole Role { get; set; }

        [JsonPropertyName("expLevel")]
        public int ExpLevel { get; set; }

        [JsonPropertyName("league")]
        public League League { get; set; }

        [JsonPropertyName("trophies")]
        public int Trophies { get; set; }

        [JsonPropertyName("versusTrophies")]
        public int VersusTrophies { get; set; }

        [JsonPropertyName("clanRank")]
        public int ClanRank { get; set; }

        [JsonPropertyName("previousClanRank")]
        public int PreviousClanRank { get; set; }

        [JsonPropertyName("donations")]
        public int Donations { get; set; }

        [JsonPropertyName("donationsRecieved")]
        public int DonationsRecieved { get; set; }

        public bool Equals(ClanMember other)
        {
            if (other == null)
                return false;

            return Tag == other.Tag;
        }
    }
}
