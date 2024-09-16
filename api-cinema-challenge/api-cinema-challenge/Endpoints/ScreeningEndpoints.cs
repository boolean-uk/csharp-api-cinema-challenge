using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {

        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("movies/{id}/screenings");

            screeningGroup.MapGet("", GetScreeningsByMovie);
            screeningGroup.MapPost("", AddScreening);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreeningsByMovie(IScreeningRepository repository, IMapper mapper, int id)
        {
            var screenings = await repository.GetScreeningsByMovie(id);
            var screeningsDTOs = mapper.Map<IEnumerable<GetScreeningDTO>>(screenings);

            var payload = new Payload<IEnumerable<GetScreeningDTO>>
            {
                Data = screeningsDTOs
            };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddScreening(IScreeningRepository repository, IMapper mapper, PostScreeningDTO screeningDTO, int id)
        {
            Screening screening = mapper.Map<Screening>(screeningDTO);
            screening.MovieId = id;
            var createdScreening = await repository.AddScreening(id, screening);
            var getScreeningDTO = mapper.Map<GetScreeningDTO>(createdScreening);
            var location = $"/movies/{id}/screenings/{createdScreening.Id}";

            var payload = new Payload<GetScreeningDTO>
            {
                Data = getScreeningDTO
            };

            return TypedResults.Created(location, payload);
        }
    }
}
