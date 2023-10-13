using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class CreateCustomerDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
