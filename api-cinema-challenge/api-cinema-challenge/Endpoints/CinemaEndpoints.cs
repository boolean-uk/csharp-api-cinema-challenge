using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using static api_cinema_challenge.Models.Movie;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoints
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var usersGroup = app.MapGroup("users");
            var movieGroup = app.MapGroup("movies");
            var screeningsGroup = app.MapGroup("screenings");

            //users
            usersGroup.MapPost("/users/", CreateUser);
            usersGroup.MapGet("/users/", GetUsers);
            usersGroup.MapPut("/users/{Id}/", UpdateUser);
            usersGroup.MapDelete("/users/{Id}/", DeleteUser);

            //movies
            movieGroup.MapPut("/movies/{Id}/", UpdateMovie);
            movieGroup.MapPost("/movies/", CreateMovie);
            movieGroup.MapGet("/movies/", GetMovies);
            movieGroup.MapDelete("/movies/{Id}", DeleteMovie);

            //screenings
            screeningsGroup.MapGet("/get/screenings", GetScreenings);
            screeningsGroup.MapPost("/create/screening", CreateScreening);

        }

        //201responses.users
        //createuser
        //updateuser
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UsersResponseDTO))]
        public static async Task<IResult> CreateUser(IRepository repository, 
            string name, string email, string phoneNumber)
        {
            var user = await repository.CreateUser(name, email, phoneNumber);
            UsersResponseDTO userToReturn = new UsersResponseDTO(user);
            return TypedResults.Created("created",userToReturn);
        }
        public static async Task<IResult> UpdateUser(IRepository repository, int id, 
            UpdateUserPayload updateData)
        {
            var user = await repository.UpdateUser(id, updateData);
            if (user == null) 
            {
                return TypedResults.NotFound(id);
            }
            UsersResponseDTO userToReturn = new UsersResponseDTO(user);
            return TypedResults.Created("updated", userToReturn);
        }

        //201responses.screenings
        //createscreening
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ScreeningResponseDTO))]
        public static async Task<IResult> CreateScreening(IRepository repository, 
            int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            var screening = await repository.CreateScreening(movieId, screenNumber, capacity, startsAt);
            ScreeningResponseDTO screeningToReturn = new ScreeningResponseDTO(screening);
            return TypedResults.Created("created", screeningToReturn);
        }

        //201responses.movies
        //CreateMovie
        //UpdateMovie
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(MovieResponseDTO))]
        public static async Task<IResult> CreateMovie(IRepository repository, 
            string title, string rating, string description, int runtime)
        {
            var movie = await repository.CreateMovie(title, rating, description, runtime);
            MovieResponseDTO MovieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Created("created", MovieToReturn);
        }
        public static async Task<IResult> UpdateMovie(IRepository repository, int id, 
            UpdateMoviePayload UpdateData)
        {
            var movie = await repository.UpdateMovie(id, UpdateData);
            if (movie == null)
            {
                return TypedResults.NotFound(id);
            }
            MovieResponseDTO MovieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Created("updated", MovieToReturn);
        }

        //200 responses
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

            if (user == null)
            {
                return TypedResults.NotFound(userId);
            }

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
            if (!screenings.Any())
            {
                return TypedResults.NotFound(movieId);
            }
            var results = new List<ScreeningResponseDTO>();
            foreach (var screening in screenings)
            {
                results.Add(new ScreeningResponseDTO(screening));
            }
            return TypedResults.Ok(results);
        }

        //delete Movie
        public static async Task<IResult> DeleteMovie(IRepository repository, int Id)
        {
            var movie = await repository.DeleteMovie(Id);

            if (movie == null)
            {
                return TypedResults.NotFound(Id);
            }

            MovieResponseDTO movieToReturn = new MovieResponseDTO(movie);
            return TypedResults.Ok(movieToReturn);
        }
    }
}   