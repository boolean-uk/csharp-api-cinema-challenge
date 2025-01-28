using api_cinema_challenge.Models;
namespace api_cinema_challenge.DTO
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        

    }
}
