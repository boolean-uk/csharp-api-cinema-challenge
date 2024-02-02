using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using static api_cinema_challenge.Models.Movie;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureUsersEndpoint(this WebApplication app)
        {
            var usersGroup = app.MapGroup("users");
            var movieGroup = app.MapGroup("movies");
            var screeningsGroup = app.MapGroup("screenings");

            usersGroup.MapPost("/create/user", CreateUser);
            usersGroup.MapGet("/get/users", GetUsers);
            usersGroup.MapPut("/update/user", UpdateUsers);
            usersGroup.MapDelete("/delete/user", DeleteUser);

            movieGroup.MapPut("update/movie", UpdateMovie);
            movieGroup.MapPost("/create/movie", CreateMovie);
            movieGroup.MapGet("/get/movies", GetMovies);
            movieGroup.MapDelete("delete/movie", DeleteMovie);

            screeningsGroup.MapGet("/get/screenings", GetScreenings);
            screeningsGroup.MapPost("/create/screening", CreateScreening);

        }

        //201responses.users
        //createuser
        //updateuser
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User))]
        public static async Task<IResult> CreateUser(IRepository repository, string name, string email, string phoneNumber)
        {
            var user = await repository.CreateUser(name, email, phoneNumber);
            UsersResponseDTO userToReturn = new UsersResponseDTO(user);
            return TypedResults.Created("created",userToReturn);
        }
        public static async Task<IResult> UpdateUsers(IRepository repository, int id, string name, string email, string phoneNumber)
        {
            var user = await repository.UpdateUser(id, name, email, phoneNumber);
            UsersResponseDTO userToReturn = new UsersResponseDTO(user);
            return TypedResults.Created("created", userToReturn);
        }

        //201responses.screenings
        //createscreening
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Screening))]
        public static async Task<IResult> CreateScreening(IRepository repository, int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            var screening = await repository.CreateScreening(movieId, screenNumber, capacity, startsAt);
            ScreeningResponseDTO screeningToReturn = new ScreeningResponseDTO(screening);
            return TypedResults.Created("created", screeningToReturn);
        }

        //201responses.movies
        //CreateMovie
        //UpdateMovie
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Movie))]
        public static async Task<IResult> CreateMovie(IRepository repository, string title, string rating, string description, int runtime)
        {
            var movie = await repository.CreateMovie(title, rating, description, runtime);
            MovieResponseDTO MovieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Created("created", MovieToReturn);
        }
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, string title, string rating, string description, int runtime)
        {
            var movie = await repository.UpdateMovie(id, title, rating, description, runtime);
            MovieResponseDTO MovieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Created("updated", MovieToReturn);
        }

        //Get requests
        [ProducesResponseType(StatusCodes.Status200OK)]
        //get all customers/users
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

        //deleteuser
        public static async Task<IResult> DeleteUser(IRepository repository, int userId)
        {
            var user = await repository.DeleteUser(userId);

            UsersResponseDTO userToReturn = new UsersResponseDTO(user);
            return TypedResults.Ok(userToReturn);
        }

        //get all movies
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

        //get screening by ID
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

        //deleteuser
        public static async Task<IResult> DeleteMovie(IRepository repository, int Id)
        {
            var movie = await repository.DeleteMovie(Id);

            MovieResponseDTO movieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Ok(movieToReturn);
        }
    }
}   