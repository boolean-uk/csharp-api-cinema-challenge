using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screening");

            screeningGroup.MapGet("/screenings/{movieId}" , GetScreenings);
            screeningGroup.MapPost("/screenings/{movieId}" , CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IScreeningRepository repository , int movieId)
        {
            return TypedResults.Ok(await repository.GetAllScreenings(movieId));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IScreeningRepository repository , int movieId , ScreeningDto screeningDto)
        {
            var screening = await repository.CreateScreening(movieId , screeningDto.ScreenNumber , screeningDto.Capacity , screeningDto.StartsAt);
            return Results.Created($"/screenings/{screening.Id}" , screening);
        }
    }
}
