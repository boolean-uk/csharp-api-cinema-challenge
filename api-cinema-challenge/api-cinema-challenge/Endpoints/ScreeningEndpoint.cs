using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");

            screenings.MapPost("/Create{movieId}", CreateScreening);
            screenings.MapGet("/GetAll{movieId}", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository repository, InputScreeningDTO data, int id)
        {
            try
            {
                //Create a screening
                CultureInfo culture = CultureInfo.InvariantCulture;
                Screening screening = new Screening()
                {
                    ScreenNumber = data.ScreenNumber,
                    Capacity = data.Capacity,
                    StartsAt = DateTime.ParseExact(data.StartsAt, "yyyy-MM-dd HH:mm:ss", culture).ToUniversalTime(),
                    MovieId = id,
                    CreatedAt = DateTime.UtcNow
                };
                screening.UpdatedAt = screening.CreatedAt;
                var result = await repository.AddScreening(screening);

                //Response
                return TypedResults.Created($"http://localhost:/screenings/{result.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            try
            {
                var result = await repository.GetScreenings(id);

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
