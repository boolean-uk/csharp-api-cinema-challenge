using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningAPI
    {
        public static void ConfigureScreeningAPI(this WebApplication app)
        {
            app.MapGet("/screenings", GetScreenings);
            app.MapPost("/screenings", AddScreening);
        }

        private static async Task<IResult> GetScreenings(IScreeningRepository context)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(context.GetScreenings());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddScreening(Screening screening, IScreeningRepository context)
        {
            try
            {
                if (context.AddScreening(screening)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
