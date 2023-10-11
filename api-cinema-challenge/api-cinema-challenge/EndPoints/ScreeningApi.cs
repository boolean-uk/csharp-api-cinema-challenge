using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapPost("/movies/{id}/screenings", CreateScreening);
            app.MapGet("/movies/{id}/screenings", GetScreenings);
        }

        /// <summary>Create a screening for an existing movie.</summary>
        /// <returns>
        /// Status 201 - Screening object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateScreening(int id, ScreeningPost s, IScreeningRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Screening screening = service.CreateScreening(id, s);
                    Payload<Screening> payload = new Payload<Screening>() { data = screening };
                    return Results.Created($"/movies/{id}/screenings/{screening.id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get a list of every screening for a movie.</summary>
        /// <returns>
        /// Status 200 - List of all screenings for a movie
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(int id, IScreeningRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Screening>> payload = new Payload<IEnumerable<Screening>>()
                    {
                        data = service.GetScreenings(id)
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
