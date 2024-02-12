using api_cinema_challenge.Models.Screenings;

namespace api_cinema_challenge.Models.Movies
{
    public struct MovieInput
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<ScreeningInput> Screenings { get; set; }
    }
}
