using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.Screening;

public class ScreeningPut
{
    [JsonPropertyName("screenNumber")]
    public int ScreenNumber { get; set; }
    
    [JsonPropertyName("capacity")]
    public int Capacity { get; set; }
    
    [JsonPropertyName("startsAt")]
    public DateTime StartsAt { get; set; }
}