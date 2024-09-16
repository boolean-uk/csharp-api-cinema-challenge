using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movies = app.MapGroup("movies");
            movies.MapPost("/", AddMovie);
            movies.MapGet("/", GetMovie);
            movies.MapPut("/{id}", UppdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddMovie(IRepository repository, string title, string rating, string description, int runtimeMins)
        {
            try
            {
                var movie = await repository.AddMovie(title, rating, description, runtimeMins);
                var dto = DTOConvert.DTOConvertObject(movie);
                return movie != null ? TypedResults.Ok(new Payload<DTOMovieObject> { data = dto }) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetMovie(IRepository repository)
        {
            try
            {
                var movies = await repository.GetMovie();
                var dto = DTOConvert.DTOConvertList(movies);
                return movies != null ? TypedResults.Ok(new Payload<IEnumerable<DTOMovieObject>> { data = dto }) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UppdateMovie(IRepository repository, int id, string? title, string? rating, string? description, int? runtimeMins)
        {
            try
            {
                var movie = await repository.UppdateMovie(id, title, rating, description, runtimeMins);
                var dto = DTOConvert.DTOConvertObject(movie);
                return movie != null ? TypedResults.Ok(new Payload<DTOMovieObject> { data = dto }) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            try
            {
                var movie = await repository.DeleteMovie(id);
                var dto = DTOConvert.DTOConvertObject(movie);
                return movie != null ? TypedResults.Ok(new Payload<DTOMovieObject> { data = dto }) : TypedResults.NotFound("NotFound");

            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }
    }
}
