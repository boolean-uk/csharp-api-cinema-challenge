using api_cinema_challenge.Enums;

namespace api_cinema_challenge.DTOs
{
    public record RegisterDTO(string Username, string Email, string Phonenumber, string Password);
    public record RegisterResponseDTO(string Username, string Email, UserRole Role);

    public record LoginDTO(string Username, string Password);
    public record LoginResponseDTO(string Token, string Name, UserRole Role);
}
