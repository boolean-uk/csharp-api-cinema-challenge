using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{

    public class ScreeningResponseDTO
    {
        public int id { get; set; }
        public MovieDTO movie { get; set; }
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public ScreeningResponseDTO(Screening screening)
        {
            id = screening.Id;
            movie = new MovieDTO(screening.Movie);
            screenNumber = screening.ScreenNumber;
            capacity = screening.Capacity;
            startsAt = screening.StartsAt;
            createdAt = screening.CreatedAt;
            updatedAt = screening.UpdatedAt;
        }
    }
}
