namespace api_cinema_challenge.Models.Posts
{
    public class MoviePost
    {
        public required string? Title { get; set; }
        public required string? Rating { get; set; }
        public required string? Description { get; set; }
        public required int? Runtime { get; set; }
        public ICollection<ScreeningPost>? Screenings { get; set; }
    }
}
