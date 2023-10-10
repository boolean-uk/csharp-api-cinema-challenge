using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapPost("/movies", CreateMovie);
            app.MapGet("/movies", GetMovies);
            app.MapPut("/movies/{id}", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        /// <summary>Create a movie</summary>
        /// <returns>
        /// Status 201 - Movie object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateMovie(MoviePost m, IMovieRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Movie movie = service.CreateMovie(m);
                    Payload<Movie> payload = new Payload<Movie>() { data = movie };
                    return Results.Created($"/movies/{movie.id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get all movies</summary>
        /// <returns>
        /// Status 200 - List of all movies
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetMovies(IMovieRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Movie>> payload = new Payload<IEnumerable<Movie>>()
                    {
                        data = service.GetMovies()
                    };
                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Update a movie</summary>
        /// <returns>
        /// Status 201 - Movie object updated
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateMovie(int id, MoviePut m, IMovieRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Movie movie = service.UpdateMovie(id, m);
                    Payload<Movie> payload = new Payload<Movie>() { data = movie };
                    return Results.Created($"/movies/{id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Delete a movie</summary>
        /// <returns>
        /// Status 200 - Movie object deleted
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteMovie(int id, IMovieRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<Movie> payload = new Payload<Movie>() { data = service.DeleteMovie(id) };
                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

    }
}
