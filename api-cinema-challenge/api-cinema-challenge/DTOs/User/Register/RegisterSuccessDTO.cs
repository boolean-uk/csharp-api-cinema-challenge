using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.User.Register;

public class RegisterSuccessDTO
{
    [JsonPropertyName("username")]
    public string Username { get; set; }
}