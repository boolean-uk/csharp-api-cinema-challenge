using api_cinema_challenge.Enums;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DataTransfer.Requests
{
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
}
