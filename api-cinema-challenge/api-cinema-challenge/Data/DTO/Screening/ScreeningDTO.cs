
using api_cinema_challenge.Model;

namespace api_cinema_challenge.Data.DTO {

    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public MovieDTO Movie { get; set; }

        public ScreeningDTO(Screening screening) {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            UpdatedAt = screening.UpdatedAt;
            Movie = new MovieDTO(screening.Movie);
        }
    }
}

