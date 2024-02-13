using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningPost
    {
        public DateTime StartTime { get; set; }
        public int MovieId { get; set; }
        public int HallId { get; set; }
    }
}
