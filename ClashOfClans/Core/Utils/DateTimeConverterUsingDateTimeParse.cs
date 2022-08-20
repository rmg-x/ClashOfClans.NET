using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClashOfClans.Core.Utils
{
    internal class DateTimeConverterUsingDateTimeParse : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string rawDatetimeValue = reader.GetString();

            if (DateTime.TryParseExact(rawDatetimeValue,
                                       ClashConstants.ClashDateFormat,
                                       CultureInfo.InvariantCulture,
                                       DateTimeStyles.None,
                                       out DateTime customClashDate))
            {
                return customClashDate;
            }

            return DateTime.Parse(rawDatetimeValue);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
