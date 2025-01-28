using api_cinema_challenge.DTO.Requests;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var m = app.MapGroup("/movies{id}/screenings");

            m.MapPost("/", CreateScreening);
            m.MapGet("/", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateScreening(IRepository<Screening> screeningRepository, IMapper mapper, int id, ScreeningRequestDto screeningDto)
        {
            var screening = mapper.Map<Screening>(screeningDto);
            screening.MovieId = id;
            var createdScreening = await screeningRepository.Insert(screening);
            await screeningRepository.Save();
            var screeningResponse = mapper.Map<ScreeningResponseDto>(createdScreening);
            var response = new Payload { Status = "success", Data = createdScreening };

            return TypedResults.Created($"/movies/{id}/screenings/{createdScreening.Id}", screeningResponse);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetScreenings(IRepository<Screening> repository, IMapper mapper)
        {
            var screenings = await repository.Get();
            var screeningDtos = mapper.Map<IEnumerable<ScreeningResponseDto>>(screenings);
            var response = new Payload { Status = "success", Data = screeningDtos };
            return TypedResults.Ok(response);
        }
    }
}
