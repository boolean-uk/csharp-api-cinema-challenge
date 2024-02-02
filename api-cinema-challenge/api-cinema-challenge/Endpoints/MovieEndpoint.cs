using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace workshop.wwwapi.Endpoints
{
    public record MoviePostPayload(string title, string rating, string description, int runtimeMins);

    public record MovieUpdatePayload(string? title, string? rating, string? description, int? runtimeMins);

    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapPut("/", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            return TypedResults.Ok(MovieResponseDTO.FromRepository(await repository.GetMovies()));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateMovie(IMovieRepository repository, MoviePostPayload payload)
        {
            if (payload.title == null || payload.title == "" ||
                payload.rating == null || payload.rating == "" ||
                payload.description == null || payload.description == "")
                return Results.BadRequest("Must have inputs");

            Movie movie = await repository.CreateMovie(payload.title, payload.rating, payload.description, payload.runtimeMins);
            if (movie == null)
                return Results.BadRequest("Title already exists");

            MovieResponseDTO mov = MovieResponseDTO.FromARepository(movie);
            return TypedResults.Created($"/movies{mov.Status} {mov.Datas}", mov);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public async static Task<IResult> UpdateMovie(IMovieRepository repository, MovieUpdatePayload posted, int id)
        {
            Movie? movie = await repository.GetMovie(id);
            if (movie == null)
                return Results.NotFound("ID out of scope");

            movie = await repository.UpdateMovie(movie, posted.title, posted.rating, posted.description, posted.runtimeMins);
            if (movie == null)
                return Results.BadRequest("Title already found");

            MovieResponseDTO mov = MovieResponseDTO.FromARepository(movie);
            return TypedResults.Created($"/movies{mov.Status} {mov.Datas}", mov);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public async static Task<IResult> DeleteMovie(IMovieRepository repository, int id)
        {
            Movie? movie = await repository.GetMovie(id);
            if (movie == null)
                return Results.NotFound("ID out of scope");

            return TypedResults.Ok(MovieResponseDTO.FromRepository(await repository.DeleteMovie(movie)));
        }
    }
}
