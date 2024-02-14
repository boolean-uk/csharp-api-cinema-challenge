using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public class ScreeningDTO : BaseEntity
    {
        public int screenNumber {  get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public int MovieId { get; set; }
    }
}
