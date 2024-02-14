using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class CustomerDTO : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
