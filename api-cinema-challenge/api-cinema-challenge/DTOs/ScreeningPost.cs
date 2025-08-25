namespace api_cinema_challenge.DTOs
{
    public class ScreeningPost
    {
        public int MovieId { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
