using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapPost("/movies", CreateAMovie);
            app.MapGet("/movies", GetAllMovies);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies", DeleteMovie);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAMovie(Movie movie, IMovieRepo service)
        {
            try
            {
                if (service.AddMovie(movie)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllMovies(IMovieRepo service)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(service.GetAllMovies());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateMovie(Movie movie, IMovieRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.UpdateMovie(movie)) return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteMovie(int id, IMovieRepo service)
        {
            try
            {
                if (service.DeleteMovie(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
