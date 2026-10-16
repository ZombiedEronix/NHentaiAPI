using System.Text.Json.Serialization;

namespace NHentaiAPI
{
    public class TagDto
    {
        [JsonPropertyName("id")]
        public int ID { get; set; } = 0;

        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("slug")]
        public string Slug { get; set; } = string.Empty;

        [JsonPropertyName("url")]
        public string URL { get; set; } = string.Empty;

        [JsonPropertyName("count")]
        public int Count { get; set; } = 1;
    }
}