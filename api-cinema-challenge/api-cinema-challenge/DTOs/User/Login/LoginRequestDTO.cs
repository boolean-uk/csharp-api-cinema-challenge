using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.User.Login;

public class LoginRequestDTO
{
    [JsonPropertyName("username")]
    public string Username { get; set; }
    
    [JsonPropertyName("password")]
    public string Password { get; set; }
}