using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Screening;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningsApi
    {
        public static void ConfigureScreeningsApi(this WebApplication app)
        {
            app.MapPost("/movies/{id}/screenings", AddScreening);
            app.MapGet("/movies/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> AddScreening(int id, ScreeningPost model, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (model == null) return Results.NotFound();

                    Screening screening = new Screening()
                    {
                        MovieId = id,
                        ScreenNumber = model.ScreenNumber,
                        Capacity = model.Capacity,
                        StartsAt = model.StartsAt,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    };

                    service.AddScreening(screening);

                    Payload<Screening> payload = new Payload<Screening>()
                    {
                        data = screening
                    };

                    return Results.Created($"/movies/{id}/screenings/{screening.Id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(int id, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Screening>> payload = new Payload<IEnumerable<Screening>>()
                    {
                        data = service.GetAllScreenings().Where(s => s.MovieId == id).ToList()
                    };

                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
