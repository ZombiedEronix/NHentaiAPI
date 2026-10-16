using System.Text.Json.Serialization;

namespace NHentaiAPI;

public class MangaMetadata
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("media_id")]
    public string MediaId { get; set; } = string.Empty;

    [JsonPropertyName("english_title")]
    public string EnglishTitle { get; set; } = string.Empty;

    [JsonPropertyName("japanese_title")]
    public string JapaneseTitle { get; set; } = string.Empty;

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; } = string.Empty;

    [JsonPropertyName("thumbnail_width")]
    public int ThumbnailWidth { get; set; }

    [JsonPropertyName("thumbnail_height")]
    public int ThumbnailHeight { get; set; }

    [JsonPropertyName("num_pages")]
    public int NumPages { get; set; }

    [JsonPropertyName("num_favorites")]
    public int NumFavorites { get; set; }

    [JsonPropertyName("tag_ids")]
    public int[] TagIds { get; set; } = Array.Empty<int>();

    [JsonPropertyName("blacklisted")]
    public bool Blacklisted { get; set; }
}
