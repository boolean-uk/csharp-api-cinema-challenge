using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
