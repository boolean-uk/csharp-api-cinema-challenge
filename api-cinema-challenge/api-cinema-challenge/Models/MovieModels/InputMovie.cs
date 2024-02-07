using api_cinema_challenge.Models.ScreeningModels;

namespace api_cinema_challenge.Models.MovieModels
{
    public class InputMovie
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public string Runtime { get; set; }
        public IEnumerable<InputScreening> Screenings { get; set; }
    }
}
