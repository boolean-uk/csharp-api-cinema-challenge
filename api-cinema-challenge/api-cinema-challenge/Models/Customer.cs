using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
       

        public string Email { get; set; }
        [Required]

        public string Phone { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        [Required]

        public DateTime UpdatedDate { get; set;} = DateTime.UtcNow;

    }
}
