namespace api_cinema_challenge.DTO
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RuntimeMins { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
