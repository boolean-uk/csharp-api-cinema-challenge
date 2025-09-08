using System.Text.Json.Serialization;

namespace api_cinema_challenge.DTOs.User.Login;

public class LoginSuccessDTO
{
    [JsonPropertyName("token")]
    public string Token { get; set; }
}