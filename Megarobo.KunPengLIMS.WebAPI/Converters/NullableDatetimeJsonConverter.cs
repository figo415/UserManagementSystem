using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Megarobo.KunPengLIMS.WebAPI.Converters
{
    public class NullableDatetimeJsonConverter : JsonConverter<DateTime?>
    {
        public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();
                if(string.IsNullOrEmpty(str))
                {
                    return null;
                }
                else
                {
                    if (DateTime.TryParse(str, out DateTime date))
                    {
                        return date;
                    }
                    return null;
                }
            }
            return reader.GetDateTime();
        }

        public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
        {
            if(value==null)
            {
                writer.WriteStringValue("");
            }
            else
            {
                writer.WriteStringValue(value.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
    }
}
