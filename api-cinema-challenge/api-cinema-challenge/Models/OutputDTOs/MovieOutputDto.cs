using api_cinema_challenge.Models.Base;

namespace api_cinema_challenge.Models.OutputDTOs
{
    public class MovieOutputDto
    {
        public static object Create(Movie movie)
        {
            var screenings = movie.Screenings;


            var screeningDtos = screenings.Select(screening => new
            {
                screening.Id,
                screening.StartsAt,
                screening.Capacity,
                screening.CreatedAt,
                screening.UpdatedAt,
                screening.ScreenNumber,
            });

            var movieDto = new
            {
                movie.Id,
                movie.Title,
                movie.Description,
                movie.Rating,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt,
                screeningDtos
            };

            return movieDto;
        }
    }
}
