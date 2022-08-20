using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Utils
{
    internal static class ClashConstants
    {
        public static JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions
        {
            Converters =
            {
                new JsonStringEnumConverter()
            }
        };

        public const string ApiBaseAddress = "https://api.clashofclans.com/v1/";

        public const string ApiAuthScheme = "Bearer";

        public const string MediaType = "application/json";

        public const string ClashDateFormat = "yyyyMMdd'T'HHmmss.fff'Z'";
    }
}
