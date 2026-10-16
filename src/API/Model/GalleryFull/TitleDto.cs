using System.Text.Json.Serialization;

namespace NHentaiAPI
{
    public class TitleDto
    {
        [JsonPropertyName("english")]
        public string English { get; set; } = string.Empty;

        [JsonPropertyName("pretty")]
        public string Pretty { get; set; } = string.Empty;
    }
}