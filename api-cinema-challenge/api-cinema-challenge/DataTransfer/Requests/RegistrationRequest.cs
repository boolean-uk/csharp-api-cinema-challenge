namespace api_cinema_challenge.DataTransfer.Requests;

using api_cinema_challenge.Enum;
using System.ComponentModel.DataAnnotations;


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