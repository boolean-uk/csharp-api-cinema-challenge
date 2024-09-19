using api_cinema_challenge.Models;

namespace api_cinema_challenge.ViewModels
{
    public class MoviePOSTModel
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<ScreeningPOSTModel>? Screenings {  get; set; }
    }
}
