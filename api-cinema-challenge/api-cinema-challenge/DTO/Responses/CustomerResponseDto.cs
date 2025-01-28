using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Responses
{
    public class CustomerResponseDto : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
