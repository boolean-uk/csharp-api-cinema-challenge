namespace api_cinema_challenge.DTOs.MovieDTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Rating { get; set; }

        public required string Description { get; set; }
        public required int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
