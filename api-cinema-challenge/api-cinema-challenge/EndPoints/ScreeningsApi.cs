using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningsApi
    {
        public static void ConfigureScreeningsApi(this WebApplication app)
        {
            app.MapGet("/Screenings", GetScreenings);
            app.MapPost("/Screenings", AddScreening);
        }

        private static async Task<IResult> AddScreening(Screenings screening, ICinemaRepository service)
        {
            try
            {
                if (service.AddScreening(screening)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetScreenings(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetScreenings());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
