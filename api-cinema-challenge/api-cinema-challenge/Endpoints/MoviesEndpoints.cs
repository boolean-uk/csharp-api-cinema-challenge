



using api_cinema_challenge.Data;
using api_cinema_challenge.Repository.Interface;

namespace api_cinema_challenge.Endpoints {
    public static class MoviesEndpoints {

        public static void ConfigureMoviesEndpoints(this WebApplication app) {
            var movies = app.MapGroup("/movies");

            movies.MapGet("/", GetMovies);
            movies.MapGet("/{id}", GetMovie);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapPost("/", CreateMovie);
            movies.MapDelete("/{Id}", DeleteMovie);
        }

        private static async Task DeleteMovie(IMovieRepository repository, int Id)
        {
            throw new NotImplementedException();
        }

        private static async Task CreateMovie(IMovieRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task UpdateMovie(IMovieRepository repository)
        {
            throw new NotImplementedException();
        }

        private static async Task GetMovie(IMovieRepository repository, int Id)
        {
            throw new NotImplementedException();
        }

        private static async Task GetMovies(IMovieRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}