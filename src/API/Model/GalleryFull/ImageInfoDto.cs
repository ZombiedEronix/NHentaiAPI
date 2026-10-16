using System.Text.Json.Serialization;

namespace NHentaiAPI;

public class ImageInfoDto
{
    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;

    [JsonPropertyName("width")]
    public int Width { get; set; } = 0;

    [JsonPropertyName("height")]
    public int Height { get; set; } = 0;
}
