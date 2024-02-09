namespace api_cinema_challenge.Models.DTOs
{
    public class MovieUpdateDTO
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int? RuntimeMins { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
