using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace api_cinema_challenge.EndPoints
{
    public static class MoviesApi
    {
        public static void ConfigureMoviesApi(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies", AddMovie);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        private static async Task<IResult> DeleteMovie(int id, ICinemaRepository service)
        {
            try
            {
                if (service.DeleteMovie(id)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem();
            }
        }

        private static async Task<IResult> UpdateMovie(Movies movie, ICinemaRepository service)
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

        private static async Task<IResult> AddMovie(Movies movie, ICinemaRepository service)
        {
            try
            {
                var newMovie = service.AddMovie(movie);
                if (newMovie != null) return Results.Ok(newMovie);
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetMovies(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetMovies());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
