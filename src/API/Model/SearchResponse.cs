using System.Text.Json.Serialization;

namespace NHentaiAPI;

public class SearchResponse
{
    [JsonPropertyName("result")]
    public List<MangaMetadata> Result { get; set; } = new();
}