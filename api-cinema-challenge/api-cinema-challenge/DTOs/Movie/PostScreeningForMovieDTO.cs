namespace api_cinema_challenge.DTOs.Movie
{
    public class PostScreeningForMovieDTO
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
