using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapGet("/screenings", GetScreenings);
            app.MapGet("/movies/{id}/screenings", GetScreeningsForMovie);
            app.MapPost("/sceenings", AddScreening);
            app.MapPut("/screenings{id}", UpdateScreening);
            app.MapDelete("/screening/{id}", DeleteScreening);
        }

        public static async Task<IResult> GetScreenings(ICinemaRepository repository)
        {
            try
            {
                var screenings = repository.GetScreenings();
                return screenings != null ? Results.Ok(screenings) : Results.Problem("There are no screenings yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetScreeningsForMovie(int movieId, ICinemaRepository repository)
        {
            try
            {
                var screenings = repository.GetScreeningsForMovie(movieId);
                return screenings != null ? Results.Ok(screenings) : Results.Problem($"There are no screenings for the movie with id of {movieId} yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddScreening(int movieId, Screening screening, ICinemaRepository repository)
        {
            try
            {
                var item = repository.AddScreening(screening, movieId);
                return item != null ? Results.Created("https://localhost:7174/screenings", item) : Results.Problem("There is no screening to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateScreening(Screening screening, ICinemaRepository repository)
        {
            try
            {
                var item = repository.UpdateScreening(screening);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no screening with id of {screening.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteScreening(int id, ICinemaRepository repository)
        {
            try
            {
                var screening = repository.DeleteScreening(id);
                return screening != null ? Results.Ok(screening) : Results.Problem($"There is no screening with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
