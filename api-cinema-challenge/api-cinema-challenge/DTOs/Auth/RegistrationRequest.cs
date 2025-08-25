using api_cinema_challenge.Enums;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace api_cinema_challenge.DTOs.Auth;




public class RegistrationRequest
{
    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Username { get { return this.Email; } set { } }

    [Required]
    public string? Password { get; set; }

    public Role Role { get; set; } = Role.User;
}
