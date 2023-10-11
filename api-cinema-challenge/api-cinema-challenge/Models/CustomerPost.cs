using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [NotMapped]
    public class CustomerPost
    {
        [Required]
        public required string name { get; set; }
        [Required]
        public required string email { get; set; }
        [Required]
        public required string phone { get; set; }
    }
}
