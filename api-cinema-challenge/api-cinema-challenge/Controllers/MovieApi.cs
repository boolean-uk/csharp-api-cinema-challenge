using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("/movies")]
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapPost("/", CreateMovie);
            movies.MapGet("/", GetMovies);
            movies.MapPut("/", UpdateMovie);
            movies.MapDelete("/", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            try
            {TestInput(id);
                Payload<MovieDTO> payload = new Payload<MovieDTO>();
                payload.data = repository.DeleteMovie(id);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound();
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest();
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateMovie(IRepository repository, int id, string title, string rating, string description, int runtime)
        {
            try
            {TestInput(id); TestInput(runtime);
                Payload<MovieDTO> payload = new Payload<MovieDTO>();
                payload.data = repository.UpdateMovie(id, title, rating, description, runtime);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest();
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetMovies(IRepository repository)
        {
            try
            {
                Payload<List<MovieDTO>> payload = new Payload<List<MovieDTO>>();
                payload.data = repository.GetMovies();
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound();
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest();
            }

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateMovie(IRepository repository, string title, string rating, string description, int runtime)
        {
            try
            {TestInput(runtime);
                Payload<MovieDTO> payload = new Payload<MovieDTO>();
                payload.data = repository.CreateMovie(title, rating, description, runtime);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest();
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest();
            }



        }

        private static void TestInput(int input)
        {
            int test = input;
        }
    }
}
