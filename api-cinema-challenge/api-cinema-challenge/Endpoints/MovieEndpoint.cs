using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapGet("/", GetAllMovies);
            movies.MapPost("/", CreateMovie);
            movies.MapPut("/", UpdateMovie);
            movies.MapDelete("/", DeleteMovie);
            movies.MapGet("/{id}/screenings", GetMovieScreenings);
            movies.MapPost("/{id}/screenings", CreateMovieScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovieScreening(IRepository repository, int movieId)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovieScreenings(IRepository repository, int movieId)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel moviePost)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, MovieUpdateModel movieUpdate)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
