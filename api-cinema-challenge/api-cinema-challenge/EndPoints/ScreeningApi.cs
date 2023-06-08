using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapGet("/screening", GetScreenings);
            app.MapPost("/screening", InsertScreening);
            app.MapPut("/screening", UpdateScreening);
            app.MapDelete("/screening/{id}", DeleteScreening);
            app.MapGet("movie{id}/screening", GetScreeningsByMovie);
        }

        private static async Task<IResult> GetScreenings(ICinemaRepository repo)
        {
            try
            {
                var screenings = repo.GetScreenings();
                return screenings != null ? Results.Ok(screenings) : Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> InsertScreening(Screening screening, int movieId, ICinemaRepository repo)
        {
            try
            {
                var addedScreening = repo.AddScreening(screening, movieId);
                return addedScreening != null ? Results.Created("https://localhost:7195/screening", addedScreening) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> UpdateScreening(Screening screening, ICinemaRepository repo)
        {
            try
            {
                var UpdatedScreening = repo.UpdateScreening(screening);
                return UpdatedScreening != null ? Results.Ok(UpdatedScreening) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> DeleteScreening(int id, ICinemaRepository repo)
        {
            try
            {
                var DeletedScreening = repo.DeleteMovie(id);
                return DeletedScreening != null ? Results.Ok(DeletedScreening) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> GetScreeningsByMovie(int Movieid, ICinemaRepository repo)
        {
            try
            {
                var screenings = repo.GetScreeningsbyMovie(Movieid);
                return screenings != null ? Results.Ok(screenings) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
