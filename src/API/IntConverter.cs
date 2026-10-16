using System.Text.Json;
using System.Text.Json.Serialization;

namespace NHentaiAPI.JSON
{
    class IntConverter : JsonConverter<int>
    {
        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var s = reader.GetString();
                return int.TryParse(s, out var v) ? v : 0;
            }
            if (reader.TokenType == JsonTokenType.Number)
                return reader.GetInt32();
            if (reader.TokenType == JsonTokenType.Null)
                return 0;
            throw new JsonException($"Unexpected token {reader.TokenType}");
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
            => writer.WriteNumberValue(value);
    }
}