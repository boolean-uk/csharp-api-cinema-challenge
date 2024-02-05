using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");

            screenings.MapPost("/{id}", AddScreening);
            screenings.MapGet("", GetAllScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddScreening(IScreeningRepository repository, ScreeningPost screening)
        {
            if (screening == null)
            {
                return TypedResults.BadRequest("Invalid input");
            }

            Screening newScreening = new Screening
            {
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
            };

            var addedScreening = await repository.AddScreening(newScreening);

            return TypedResults.Created($"/{addedScreening.Id}", addedScreening.ToDTO());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IScreeningRepository repository)
        {
            var screenings = await repository.GetAllScreenings();
            List<ScreeningDTO> screeningDTO = new List<ScreeningDTO>();

            foreach (var screening in screenings)
            {
                screeningDTO.Add(screening.ToDTO());
            }

            return TypedResults.Ok(screeningDTO);
        }
    }
}
