using ClashOfClans.Core.Players.Interfaces;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Players
{
    public class ClashTokenVerification : IClashTokenVerification
    {
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("status")]
        public PlayerTokenStatus Status { get; set; }
    }
}
