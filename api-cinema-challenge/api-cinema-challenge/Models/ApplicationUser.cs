using Microsoft.AspNetCore.Identity;
using api_cinema_challenge.Models.Enums;

namespace api_cinema_challenge.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Role Role { get; set; }
    }
}
