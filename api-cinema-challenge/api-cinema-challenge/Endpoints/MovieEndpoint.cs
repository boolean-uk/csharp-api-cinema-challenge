
namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");

            movieGroup.MapPost("/CreateMovie", CreateMovie);
            movieGroup.MapGet("/GetAllMovie", GetMovies);
            movieGroup.MapPut("/UpdateMovie/{id}", UpdateMovieById);
            movieGroup.MapDelete("DeleteMovie/{id}", DeleteMovieById);
        }

        private static async Task<IResult> DeleteMovieById(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> UpdateMovieById(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> GetMovies(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> CreateMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
