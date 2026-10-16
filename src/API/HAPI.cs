namespace NHentaiAPI;


using System.Text.Json;
using NHentaiAPI.JSON;
public static class HAPI
{
    private static readonly JsonSerializerOptions _jsonOptions = new()
    {
        Converters = { new IntConverter()},
        PropertyNameCaseInsensitive = true
    };

    private static readonly HttpClient client = new HttpClient();
    const string DomainName = "nhentai.net";

    private static async Task<string> GET(string parameters)
    {
        string searchUrl = $"https://{DomainName}/api/v2/{parameters}";

        using var request = new HttpRequestMessage(HttpMethod.Get, searchUrl);

        using var response = await client.SendAsync(request);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadAsStringAsync();
    }

    public static async Task<MangaResponse?> GetRandomGallery()
    {
        string apiResponse = await GET("galleries/random");

        RandomResponse? item = JsonSerializer.Deserialize<RandomResponse>(apiResponse, _jsonOptions);

        if(item != null)
        {
            return await GetGallery(item.ID);
        }
        return null;
    }

    public static async Task<List<MangaMetadata>?> GetPopular()
    {
        string apiResponse = await GET("galleries/popular");
        return JsonSerializer.Deserialize<List<MangaMetadata>>(apiResponse, _jsonOptions);
    }

    public static async Task<SearchResponse?> Search(string query, int page = 1)
    {
        string apiResponse = await GET($"search?query={query}&page={page}");
        SearchResponse? response = JsonSerializer.Deserialize<SearchResponse>(apiResponse, _jsonOptions);
        return response;          
    }

    public static async Task<List<MangaMetadata>?> GetGalleriesByTag(int tagId, int page = 1)
    {
        string apiResponse = await GET($"galleries/tag/{tagId}?page={page}");

        SearchResponse? response = JsonSerializer.Deserialize<SearchResponse>(apiResponse, _jsonOptions);

        return response.Result;
    }

    public static async Task<SearchResponse?> GetGalleries(int page = 1)
    {
        string apiResponse = await GET($"galleries?page={page}");
        SearchResponse? response = JsonSerializer.Deserialize<SearchResponse>(apiResponse, _jsonOptions);
        return response;
    }

    public static async Task<MangaResponse> GetGallery(int id)
    {
        string apiResponse = await GET($"galleries/{id}");
        return JsonSerializer.Deserialize<MangaResponse>(apiResponse, _jsonOptions);
    }
}