using api_cinema_challenge.Models.DTO.ScreeningDTOs;

namespace api_cinema_challenge.Models.DTO.MovieDTOs
{
    public class CreateMovieDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<CreateScreeningDTO> Screenings { get; set; }
    }
}
