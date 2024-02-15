using api_cinema_challenge.Models.Base;

namespace api_cinema_challenge.Models.InputDTOs
{
    public class MovieInputDto
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

        public ICollection<ScreeningInputDto>? Screenings { get; set; }
    }
}
