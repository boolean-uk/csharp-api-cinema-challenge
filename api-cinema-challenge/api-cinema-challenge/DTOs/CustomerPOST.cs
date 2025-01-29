using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTOs
{
    public class CustomerPOST
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
