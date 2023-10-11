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
        private static async Task<IResult> CreateAScreening(ScreeningPost screening, IScreeningRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (screening == null) return Results.NotFound();
                    Screening newScreening = new Screening();
                    newScreening.screenNumber = screening.screenNumber;
                    newScreening.capacity = screening.capacity;
                    newScreening.startsAt = screening.startsAt;
                    service.AddScreening(newScreening);
                    Payload<Screening> payload = new Payload<Screening>()
                    {
                        data = newScreening
                    };

                    return Results.Created($"https://localhost:7195/customer/{newScreening.Id}", payload);
                });
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
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Screening>> payload = new Payload<IEnumerable<Screening>>()
                    {
                        data = service.GetAllScreenings().ToList()
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
