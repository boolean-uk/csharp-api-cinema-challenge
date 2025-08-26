using api_cinema_challenge.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("Users")]
    public class ApplicationUser : IdentityUser
    {
        public Role Role { get; set; }
    }
}
