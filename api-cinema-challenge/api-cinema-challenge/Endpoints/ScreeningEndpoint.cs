
using api_cinema_challenge.Payloads;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigurescreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screening");

            screeningGroup.MapPost("/CreateScreening/{id}", CreateScreeningByMovieId);
            screeningGroup.MapGet("/GetAllScreening{id}", GetScreeningsByMovieId);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreeningsByMovieId(IRepository repository, int movieId)
        {
            try
            {
                return TypedResults.Ok(await repository.GetScreenings(movieId));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateScreeningByMovieId(IRepository repository, int movieId, ScreeningPayload payload)
        {
            try
            {
                var result = await repository.CreateScreening(movieId, payload);
                return TypedResults.Created($"http://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
