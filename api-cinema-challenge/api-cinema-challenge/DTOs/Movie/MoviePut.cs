using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.Movie;

public class MoviePut
{
    [JsonPropertyName("title")]
    public string Title { get; set; }
    
    [JsonPropertyName("rating")]
    public string Rating { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("runtimeMins")]
    public int RuntimeMins { get; set; }
}