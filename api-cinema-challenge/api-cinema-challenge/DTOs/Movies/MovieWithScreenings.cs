using api_cinema_challenge.DTOs.Screenings;

namespace api_cinema_challenge.DTOs.Movies
{
    public class MovieWithScreenings
    {
        public int Id { get; set; }
        public List<ScreeningsForMovie> Screenings { get; set; } = new List<ScreeningsForMovie>();
    }
}
