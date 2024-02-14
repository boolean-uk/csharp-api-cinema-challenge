using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/movies");
            movieGroup.MapGet("", GetMovies);
            movieGroup.MapGet("/{id}", GetMovieById);
        }

        private static async Task<IResult> GetMovies(IRepository<Movie> repo)
        {
            var movies = await repo.Get();
            return Results.Ok(movies.Select(movie => new {
                movie.Id,
                movie.Title,
                movie.Rating,
                movie.Description,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt
            }));
        }

        private static async Task<IResult> GetMovieById(IRepository<Movie> repo, int id)
        {
            var movie = await repo.GetByIdAsync(id);
            if (movie == null) return Results.NotFound();

            return Results.Ok(new
            {
                movie.Id,
                movie.Title,
                movie.Rating,
                movie.Description,
                movie.RuntimeMins,
                movie.CreatedAt,
                movie.UpdatedAt
            });
        }
    }

}
