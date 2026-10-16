using System.Text.Json.Serialization;

namespace NHentaiAPI;

public class RandomResponse
{
    [JsonPropertyName("id")]
    public int ID { get; set; } = 1;
}
