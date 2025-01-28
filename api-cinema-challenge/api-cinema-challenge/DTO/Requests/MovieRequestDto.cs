namespace api_cinema_challenge.DTO.Requests
{
    public class MovieRequestDto
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public IEnumerable<ScreeningRequestDto>? screeningRequestDtos { get; set; }
    }
}
