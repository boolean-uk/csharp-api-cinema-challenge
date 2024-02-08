

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", CreateMovie);
            customers.MapGet("", ReadAllMovies);
            customers.MapPut("/{id}", ReadAMovie);
            customers.MapPut("/{id}", UpdateMovie);
            customers.MapDelete("/{id}", DeleteMovie);
        }

        private static Task CreateMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAllMovies(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
