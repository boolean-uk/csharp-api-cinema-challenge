using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningAPI(this WebApplication app)
        {
            app.MapGet("/Screenings", GetScreenings);
            app.MapPost("/Screenings", AddScreenings);
            app.MapGet("/Screenings/{id}", GetScreening);
            app.MapDelete("/Screenings/{id}", DeleteScreenings);
            app.MapPut("/Screenings/{id}", UpdateScreenings);




        }


        private static async Task<IResult> GetScreening(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.GetScreeningById(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Screening with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> AddScreenings(ICinemaRepo repo, Screening screen)
        {
            try
            {
                return Results.Ok(repo.CreateScreening(screen));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetScreenings(ICinemaRepo repo)
        {
            try
            {
                return Results.Ok(repo.GetallScreenings());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteScreenings(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.DeleteScreening(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Screening with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
        private static async Task<IResult> UpdateScreenings(ICinemaRepo repo, int id, Screening screen)
        {
            try
            {
                var result = repo.UpdateScreening(screen, id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Screening with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}

