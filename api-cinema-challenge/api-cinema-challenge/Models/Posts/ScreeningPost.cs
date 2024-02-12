using api_cinema_challenge.Models.Interfaces;

namespace api_cinema_challenge.Models.Posts
{
    public class ScreeningPost : IScreening
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
