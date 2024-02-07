using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs.Custommer
{
    public class OutCustommerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<OutTicketDTO> Tickets { get; set; } = new List<OutTicketDTO>();
    }
}
