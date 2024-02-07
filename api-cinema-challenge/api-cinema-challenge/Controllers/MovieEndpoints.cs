using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOS.movieDTOS;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movies = app.MapGroup("/movies");

            movies.MapPost("", CreateMovie);
            movies.MapGet("", GetAllMovies);
            movies.MapPut("/{id}", UpdateMovieById);
            movies.MapDelete("/{id}", DeleteMovieById);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> CreateMovie(IMovieRepository repository, MoviePayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }

            var newMovie = await repository.Add(payload.Title, payload.Rating, payload.Description, payload.RunttimeMins);
            return newMovie == null ? TypedResults.BadRequest() : TypedResults.Created($"/movies/{newMovie.Id}", new MovieDTO(newMovie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private async static Task<IResult> GetAllMovies(IMovieRepository repository)
        {
            var allMovies = await repository.GetAll();
            var resultMovies = new List<MovieWScreeningDTO>();
            if (allMovies.Count == 0) { return TypedResults.NotFound("No movies where found"); }

            foreach (var movie in allMovies)
            {
                resultMovies.Add(new MovieWScreeningDTO(movie));
            }

            return TypedResults.Ok(resultMovies);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private async static Task<IResult> UpdateMovieById(IMovieRepository repository, int id, MoviePayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }

            var movie = await repository.Update(id, payload.Title, payload.Rating, payload.Description, payload.RunttimeMins);
            return movie == null ?
                TypedResults.NotFound($"Movie not found with id {id}") :
                TypedResults.Created($"/movies/{movie.Id}", new MovieDTO(movie));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteMovieById(IMovieRepository repository, int id)
        {
            if (await repository.Get(id) == null) { return TypedResults.NotFound($"Movie not found with id {id}"); }

            var movie = await repository.SoftDelete(id);

            //TODO Check for error
            return movie == null ? TypedResults.BadRequest("error") : TypedResults.Ok(new MovieDTO(movie));
        }
    }
}
