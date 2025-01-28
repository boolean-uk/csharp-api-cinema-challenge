using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public MovieDTO Movie { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public List<TicketDTO> Tickets { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
