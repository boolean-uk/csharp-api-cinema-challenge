
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            cinema.MapGet("/movies", GetAllMovies);
        }

        public static async Task GetAllMovies(IRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
