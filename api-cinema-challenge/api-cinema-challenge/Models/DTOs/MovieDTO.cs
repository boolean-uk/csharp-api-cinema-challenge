namespace api_cinema_challenge.Models.DTOs
{
    public class MovieDTO
    {
        public required string Title { get; set; }
        public required string Rating { get; set; }
        public required string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
