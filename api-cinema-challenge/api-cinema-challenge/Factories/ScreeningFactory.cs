using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Factories
{
    public static class ScreeningFactory
    {
        public static Screening ScreeningFromPostDto(ScreeningPostDto dtp, int movieId)
        {
            var screening = new Screening();

            screening.MovieId = movieId;
            screening.ScreenNumber = dtp.ScreenNumber;
            screening.Capacity = dtp.Capacity;
            screening.StartsAt = dtp.StartsAt;
            screening.CreatedAt = DateTime.UtcNow;
            screening.UpdatedAt = DateTime.UtcNow;

            return screening;
        }

        public static ScreeningDto DtoFromScreening(Screening screening)
        {
            var dto = new ScreeningDto();

            dto.Id = screening.Id;
            dto.ScreenNumber = screening.ScreenNumber;
            dto.Capacity = screening.Capacity;
            dto.StartsAt = screening.StartsAt;
            dto.CreatedAt = DateTime.UtcNow;
            dto.UpdatedAt = DateTime.UtcNow;

            return dto;
        }
    }
}
