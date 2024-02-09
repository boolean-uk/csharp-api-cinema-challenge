namespace api_cinema_challenge.Models.DTOs
{
    public class CreateMovieDTO
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<ScreeningForMovieDTO>? Screenings { get; set; } = new List<ScreeningForMovieDTO>();

    }
}
