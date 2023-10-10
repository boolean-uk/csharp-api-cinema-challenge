using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapPost("/screenings", CreateAScreening);
            app.MapGet("/screenings", GetAllScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAScreening(Screening screening, IScreeningRepo service)
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

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllScreenings(IScreeningRepo service)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(service.GetAllScreenings());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
