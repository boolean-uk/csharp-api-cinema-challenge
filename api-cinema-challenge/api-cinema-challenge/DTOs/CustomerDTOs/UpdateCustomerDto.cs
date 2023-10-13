using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class UpdateCustomerDto
    {
        [MaxLength(50)]
        public string Name { get; set; }

        [EmailAddress]
        [MaxLength(200)]
        public string Email { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }
    }
}
