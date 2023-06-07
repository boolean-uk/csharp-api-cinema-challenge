using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieAPI
    {
        public static void ConfigureMovieAPI(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapGet("/movies/{id}", GetMovie);
            app.MapPost("/movies", AddMovie);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies", DeleteMovie);
        }

        private static async Task<IResult> GetMovies(IMovieRepository context)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(context.GetMovies());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetMovie(int id, IMovieRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var movie = context.GetMovie(id);
                    if (movie == null) return Results.NotFound();
                    return Results.Ok(movie);
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddMovie(Movie movie, IMovieRepository context)
        {
            try
            {
                if (context.AddMovie(movie)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> UpdateMovie(Movie movie, IMovieRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (context.UpdateMovie(movie)) return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteMovie(int id, IMovieRepository context)
        {
            try
            {
                if (context.DeleteMovie(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
