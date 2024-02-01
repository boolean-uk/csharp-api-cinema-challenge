using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using static api_cinema_challenge.Models.Movie;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureUsersEndpoint(this WebApplication app)
        {
            var usersGroup = app.MapGroup("users");

            usersGroup.MapGet("/users", GetUsers);
        }

        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/movies", GetMovies);
        }

        public static void configureScreeningsEndpoint(this WebApplication app)
        {
            var screeningsGroup = app.MapGroup("screenings");
            screeningsGroup.MapGet("/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetUsers(IRepository repository)
        {
            var users = await repository.GetUsers();
            var results = new List<UsersResponseDTO>();
            foreach (var user in users)
            {
                results.Add(new UsersResponseDTO(user));
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            var results = new List<MovieResponseDTO>();
            foreach (var movie in movies)
            {
                results.Add(new MovieResponseDTO(movie));
            }
            return TypedResults.Ok(results);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            var screenings = await repository.GetScreeningsByMovieId(movieId);
            var results = new List<ScreeningResponseDTO>();
            foreach (var screening in screenings)
            {
                results.Add(new ScreeningResponseDTO(screening));
            }
            return TypedResults.Ok(results);
        }
    }
}   
