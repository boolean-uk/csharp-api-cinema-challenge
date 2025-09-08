using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.Screening;

public class ScreeningPost
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("screenNumber")]
    public int ScreenNumber { get; set; }
    
    [JsonPropertyName("capacity")]
    public int Capacity { get; set; }
    
    [JsonPropertyName("startsAt")]
    public DateTime StartsAt { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }
}