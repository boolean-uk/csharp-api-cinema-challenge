using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class CustomerPostDto
    {
        public required string Name { get; set; }
        [EmailAddress]
        public required string Email { get; set; }
        [Phone]
        public required string Phone { get; set; }
      
    }
}
