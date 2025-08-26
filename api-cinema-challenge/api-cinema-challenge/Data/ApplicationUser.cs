using api_cinema_challenge.Enums;
using Microsoft.AspNetCore.Identity;

namespace api_cinema_challenge.Data
{
        public class ApplicationUser : IdentityUser
        {
            public Role Role { get; set; }
        }
    }

