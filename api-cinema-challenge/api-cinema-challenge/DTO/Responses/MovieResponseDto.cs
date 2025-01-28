using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Responses
{
    public class MovieResponseDto : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }

    }
}
