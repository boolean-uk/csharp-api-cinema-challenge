using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;

namespace api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings
{
    public class ScreeningInsertResultDTO
    {
        public ScreeningInsertResultDTO(Screening screening, int screenNumber, int numSeats)
        {
            StartsAt = screening.StartsAt.ToString("yyyy-MM-ddTHH:mm:ss");
            ScreenNumber = screenNumber;
            NumSeats = numSeats;
        }
        public string StartsAt { get; set; }
        public int ScreenNumber { get; set; }
        public int NumSeats { get; set; }
    }
}
