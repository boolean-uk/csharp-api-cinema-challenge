using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using api_cinema_challenge.Enums;

namespace api_cinema_challenge.Models
{

    [Table("applicationusers")]

    public class ApplicationUser : IdentityUser
    {

        [Column("role")]
        public UserRole Role { get; set; }


    }

}