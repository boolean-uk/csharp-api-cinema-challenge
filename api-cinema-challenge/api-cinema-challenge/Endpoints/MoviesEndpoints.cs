



using api_cinema_challenge.Data;
using api_cinema_challenge.Data.DTO;
using api_cinema_challenge.Data.Payload;
using api_cinema_challenge.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints {
    public static class MoviesEndpoints {

        public static void ConfigureMoviesEndpoints(this WebApplication app) {
            var movies = app.MapGroup("/movies");

            movies.MapGet("/", GetMovies);
            movies.MapGet("/{id}", GetMovie);
            movies.MapPost("/", CreateMovie);
            movies.MapDelete("/{Id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IMovieRepository repository, int Id)
        {
            if(Id <= 0)
                return Results.BadRequest("Must be a postive ID");
            var Movie = await repository.GetMovie(Id);
            if(Movie == null)
                return Results.NotFound("No movie found with Id: " + Id);
            await repository.DeleteMovie(Id);
            return TypedResults.Ok();
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateMovie(IMovieRepository repository, CreateMoviePayload payload)
        {
            if(payload.Title == null)
                return Results.BadRequest("Title cannot be null");
            if(payload.Rating == null)
                return Results.BadRequest("Rating cannot be null");
            if(payload.RuntimeMins == null)
                return Results.BadRequest("Runtime cannot be null");

            return TypedResults.Created("Created", await repository.CreateMovie(payload.Title, payload.Rating, payload.Description, payload.RuntimeMins));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovie(IMovieRepository repository, int Id)
        {
            var movies = await repository.GetMovie(Id);
            if(movies == null)
                return Results.NotFound("No movie with Id: " + Id + " Found");
            return TypedResults.Ok(new MovieScreeningDTO(movies));
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            return TypedResults.Ok(MovieDTO.FromRepository(await repository.GetAllMovies()));
        }
    }
}