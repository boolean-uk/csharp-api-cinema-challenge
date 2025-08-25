using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTOs.CustomerDTOs
{
    public class CustomerPutDto
    {
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Phone]
        public string? Phone { get; set; }
    }
}
