using System.Text.Json.Serialization;

namespace NHentaiAPI;

public class PageDto
{
    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; } = string.Empty;

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; } = string.Empty;

    [JsonPropertyName("thumbnail_width")]
    public int ThumbnailWidth { get; set; }

    [JsonPropertyName("thumbnail_height")]
    public int ThumbnailHeight { get; set; }

    public string FullImageUrl => $"https://i.nhentai.net/{Path}";
    public string ThumbnailUrl => $"https://t.nhentai.net/{Thumbnail}";
}
