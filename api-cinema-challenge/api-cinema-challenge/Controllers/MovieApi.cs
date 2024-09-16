using api_cinema_challenge.Models.Movie;
using api_cinema_challenge.Models.Ticket;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    [ApiController]
    [Route("/movies")]
    public static class MovieApi
    {
        private static string payloadStatusSuccess = "Success";
        private static string payloadStatusFailure = "Failure";
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
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
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
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
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
                payload = checkPayloadList(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.NotFound(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
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
                payload = checkPayload(payload);
                return payload.data != null ? TypedResults.Ok(payload) : TypedResults.BadRequest(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }

        private static Payload<MovieDTO> checkPayload(Payload<MovieDTO> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static Payload<List<MovieDTO>> checkPayloadList(Payload<List<MovieDTO>> payload)
        {
            if (payload.data != null)
            {
                payload.status = payloadStatusSuccess;
                return payload;
            }
            else
            {
                payload.status = payloadStatusFailure;
                return payload;
            }
        }

        private static void TestInput(int input)
        {
            int test = input;
        }
    }
}
