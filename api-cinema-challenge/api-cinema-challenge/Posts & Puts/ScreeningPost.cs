using api_cinema_challenge.Models;

namespace api_cinema_challenge.Posts___Puts
{
    public class ScreeningPost
    {
        public int screenNumber {  get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public int movieId { get; set; }
        
    }
}
