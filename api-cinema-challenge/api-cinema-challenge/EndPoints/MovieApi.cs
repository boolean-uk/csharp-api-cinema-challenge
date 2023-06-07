using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class MovieApi
    {
        public static void ConfigureMovieApi(this WebApplication app)
        {
            app.MapGet("/movies", GetMovies);
            app.MapPost("/movies", AddMovie);
            app.MapPut("/movies", UpdateMovie);
            app.MapDelete("/movies/{id}", DeleteMovie);
        }

        public static async Task<IResult> GetMovies(ICinemaRepository repository)
        {
            try
            {
                var movies = repository.GetMovies();
                return movies != null ? Results.Ok(movies) : Results.Problem("There are no movies yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddMovie(Movie movie, ICinemaRepository repository)
        {
            try
            {
                var item = repository.AddMovie(movie);
                return item != null ? Results.Created("https://localhost:7174/movies", item) : Results.Problem("There is no movie to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateMovie(Movie movie, ICinemaRepository repository)
        {
            try
            {
                var item = repository.UpdateMovie(movie);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no movie with id of {movie.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteMovie(int id, ICinemaRepository repository)
        {
            try
            {
                var movie = repository.DeleteMovie(id);
                return movie != null ? Results.Ok(movie) : Results.Problem($"There is no movie with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
