using Microsoft.AspNetCore.Identity;
using api_cinema_challenge.Enum;

namespace api_cinema_challenge.Models
{
    public class ApplicationUser : IdentityUser
    {
        public UserRole Role { get; set; }
    }
}
