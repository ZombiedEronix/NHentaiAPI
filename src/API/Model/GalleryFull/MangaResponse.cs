using System.Text.Json.Serialization;

namespace NHentaiAPI
{
    public class MangaResponse
    {
        [JsonPropertyName("id")]
        public int ID { get; set; } = 1;

        [JsonPropertyName("media_id")]
        public int MediaID { get; set; } = 1;

        [JsonPropertyName("title")]
        public TitleDto Title { get; set; } = new();

        [JsonPropertyName("cover")]
        public ImageInfoDto Cover { get; set; } = new();

        [JsonPropertyName("thumbnail")]
        public ImageInfoDto Thumbnail { get; set; } = new();

        [JsonPropertyName("scanlator")]
        public string Scanlator { get; set; } = string.Empty;

        [JsonPropertyName("upload_date")]
        public int UploadTime { get; set; } = 0;

        [JsonPropertyName("tags")]
        public List<TagDto> Tags { get; set; } = new();

        [JsonPropertyName("num_pages")]
        public int NumPages {get; set;} = 0;

        [JsonPropertyName("num_favorites")]
        public int NumFavorites { get; set; } = 0;

        [JsonPropertyName("pages")]
        public List<PageDto> Pages {get; set;} = new();

    }
}