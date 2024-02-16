using api_cinema_challenge.Models.Base;

namespace api_cinema_challenge.Models.OutputDTOs
{
    public class ScreeningOutputDto
    {
        public static object Create(Screening screening)
        {
            var movie = screening.Movie;

            var movieDto = new
            {
                movie.Id,
                movie.Title,
                movie.Description,
                movie.Rating,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt,
            };

            var screeningDto = new
            {
                screening.Id,
                screening.StartsAt,
                screening.ScreenNumber,
                screening.Capacity,
                screening.CreatedAt,
                screening.UpdatedAt,
                movieDto,
            };

            return screeningDto;
        }
    }
}
