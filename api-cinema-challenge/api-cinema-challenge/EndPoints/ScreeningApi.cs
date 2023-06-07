using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapGet("/screenings/{id}", GetScreenings);
            app.MapPost("/screenings", AddScreening);
        }

        public static async Task<IResult> GetScreenings(iRepositoryCinema repository, int id)
        {
            try
            {
                var screenings = repository.GetScreenings(id);
                return screenings != null ? Results.Ok(screenings) : Results.Problem("There are no screenings yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddScreening(iRepositoryCinema repository, Screening screening)
        {
            try
            {
                var item = repository.AddScreening(screening);
                return item != null ? Results.Created("https://localhost:7174/screenings", screening) : Results.Problem("There is no screening to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
