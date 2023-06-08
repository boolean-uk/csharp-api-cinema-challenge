using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies", InsertMovie);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        private static async Task<IResult> GetMovies(ICinemaRepository repo)
        {
            try
            {
                var movies = repo.GetMovies();
                return movies != null ? Results.Ok(movies) : Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> InsertMovie(Movie movie, ICinemaRepository repo)
        {
            try
            {
                var addedMovie = repo.AddMovie(movie);
                return addedMovie != null ? Results.Created("https://localhost:7195/movies", addedMovie) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> UpdateMovie(Movie movie, ICinemaRepository repo)
        {
            try
            {
                var UpdatedMovie = repo.UpdateMovie(movie);
                return UpdatedMovie != null ? Results.Ok(UpdatedMovie) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> DeleteMovie(int id, ICinemaRepository repo)
        {
            try
            {
                var DeletedMovie = repo.DeleteMovie(id);
                return DeletedMovie != null ? Results.Ok(DeletedMovie) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
