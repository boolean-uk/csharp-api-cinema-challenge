using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieAPI(this WebApplication app)
        {
            app.MapGet("/Movies", GetMovies);
            app.MapPost("/Movies", AddMovies);
            app.MapGet("/Movies/{id}", GetMovie);
            app.MapDelete("/Movies/{id}", DeleteMovie);
            app.MapPut("/Movies/{id}", UpdateMovie);




        }


        private static async Task<IResult> GetMovie(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.GetMovieById(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Movie with id {id} not found");
             }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> AddMovies(ICinemaRepo repo, Movie movie)
        {
            try
            {
                return Results.Ok(repo.CreateMovie(movie));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetMovies(ICinemaRepo repo)
        {
            try
            {
                return Results.Ok(repo.GetallMovies());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteMovie(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.DeleteMovie(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Movie with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
        private static async Task<IResult> UpdateMovie(ICinemaRepo repo, int id, Movie movie)
        {
            try
            {
                var result = repo.UpdateMovie(movie,id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Movie with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
