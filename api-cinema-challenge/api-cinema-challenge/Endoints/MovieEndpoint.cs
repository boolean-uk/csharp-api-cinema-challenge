using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");

            // Movie endpoints
            movieGroup.MapGet("/movies" , GetMovies);
            movieGroup.MapGet("/movies/{id}" , GetMovieById);
            movieGroup.MapPost("/movies" , CreateMovie);
            movieGroup.MapPut("/movies/{id}" , UpdateMovie);
            movieGroup.MapDelete("/movies/{id}" , DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllMovies());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovieById(IMovieRepository repository , int id)
        {
            var movie = await repository.GetMovie(id);
            if(movie == null)
            {
                return Results.NotFound($"Movie with ID {id} not found.");
            }
            return Results.Ok(movie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IMovieRepository repository , MovieDto movieDto)
        {
            var movie = await repository.CreateMovie(movieDto.Title , movieDto.Rating , movieDto.Description , movieDto.RuntimeMins);
            return Results.Created($"/movies/{movie.Id}" , movie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository , int id , MovieDto movieDto)
        {
            var movie = await repository.UpdateMovie(id , movieDto.Title , movieDto.Rating , movieDto.Description , movieDto.RuntimeMins);
            if(movie == null)
            {
                return Results.NotFound($"Movie with ID {id} not found.");
            }
            return Results.Ok(movie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository , int id)
        {
            var movie = await repository.DeleteMovie(id);
            if(movie == null)
            {
                return Results.NotFound($"Movie with ID {id} not found.");
            }
            return Results.Ok(movie);
        }
    }
}
