namespace api_cinema_challenge.DTO.Requests
{
    public class MovieUpdateDto
    {
        public string? Title { get; set; }
        public string? Rating { get; set; }
        public string? Description { get; set; }
        public int? RuntimeMins { get; set; }
    }
}
