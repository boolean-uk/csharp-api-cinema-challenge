using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("/movies/");

            screeningGroup.MapGet("{id}/screeings", GetScreenings);
            screeningGroup.MapPost("{id}/screeings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IScreeningRepository screeningRepository)
        {
            var screenings = await screeningRepository.GetScreenings();

            List<ScreeningDTO> result = new List<ScreeningDTO>();

            foreach (var screening in screenings)
            {
                ScreeningDTO screeningDTO = new ScreeningDTO()
                {
                    Capacity = screening.Capacity,
                    ScreenNumber = screening.ScreenNumber,
                    startsAt = screening.startsAt,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt
                    
                };
                result.Add(screeningDTO);
            }

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IScreeningRepository screeningRepository, int id, Screening screening)
        {
            var createdSCreening = await screeningRepository.CreateScreening(id, screening);

            ScreeningDTO aScreening = new ScreeningDTO()
            {
                Capacity = screening.Capacity,
                ScreenNumber = screening.ScreenNumber,
                startsAt = screening.startsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            return TypedResults.Ok(aScreening);
        }
    }
}
