using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Facebook.NetCore.Service.JsonConverters
{
    internal class DictionnaryJsonConverter : JsonConverter<Dictionary<string, int>>
    {
        public override Dictionary<string, int> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            int value;
            if(reader.TokenType == JsonTokenType.Number && reader.TryGetInt32(out value))
            {
                return new Dictionary<string, int>
                {
                    { "default", value }
                };
            }
            else if(reader.TokenType == JsonTokenType.StartObject)
            {
                var jsonDoc = JsonDocument.ParseValue(ref reader);
                var dictionnary = JsonSerializer.Deserialize<Dictionary<string, int>>(jsonDoc.RootElement.GetRawText());

                return dictionnary;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<string, int> value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
