using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class TicketPut
    {
        public int ScreeningId { get; set; }
        public int SeatId { get; set; }
    }
}
