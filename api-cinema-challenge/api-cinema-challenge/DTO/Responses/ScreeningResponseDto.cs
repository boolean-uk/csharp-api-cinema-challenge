using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Responses
{
    public class ScreeningResponseDto : BaseEntity
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int capacity { get; set; }
        public string startsAt { get; set; }

    }
}
