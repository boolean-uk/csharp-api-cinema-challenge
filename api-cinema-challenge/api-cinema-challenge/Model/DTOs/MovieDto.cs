namespace api_cinema_challenge.Model.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
