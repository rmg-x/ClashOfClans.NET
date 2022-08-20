using ClashOfClans.Core.GoldPass.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.GoldPass
{
    public class GoldPassInformation : IGoldPassInformation
    {
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }
    }
}
