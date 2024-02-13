using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class SeatPost
    {
        public int HallId { get; set; }
        public string SeatRow { get; set; }
        public int SeatNumber { get; set; }
    }
}
