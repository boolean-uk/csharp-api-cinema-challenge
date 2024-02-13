namespace api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings
{
    public class MoviePostDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public ICollection<ScreeningInputDTO> Screenings { get; set; }
    }
}
