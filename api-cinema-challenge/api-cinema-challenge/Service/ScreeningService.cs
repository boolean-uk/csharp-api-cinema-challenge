using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Service
{
    public class ScreeningService
    {
        public static Screening toScreening(ScreeningDto screening, int movieId)
        {
            return new Screening()
            {
                StartsAt = screening.StartsAt, 
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = DateTime.UtcNow, 
                MovieId = movieId
            };
        }

        public static Screening updateScreening(Screening screening, ScreeningDto screeningDto)
        {
            screening.StartsAt = screeningDto.StartsAt;
            screening.ScreenNumber = screeningDto.ScreenNumber;
            screening.Capacity = screeningDto.Capacity;
            screening.UpdatedAt = DateTime.UtcNow;

            return screening;
        }
    }
}
