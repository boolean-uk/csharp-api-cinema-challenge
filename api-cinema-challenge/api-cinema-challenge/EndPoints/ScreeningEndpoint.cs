using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Dtos;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningEndpoint
    {
        public static void configureScreeningEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("/movies");
            group.MapGet("/{id:int}/screenings", GetScreenings);
            group.MapPost("/{id:int}/screenings", CreateScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IScreeningRepository repository, int id)
        {
            var screenings = await repository.GetScreenings(id);
            Payload<ICollection<Screening>> payload = new Payload<ICollection<Screening>>();
            payload.status = "success";
            payload.data = screenings;
            return TypedResults.Ok(payload); 
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> CreateScreening(IScreeningRepository repository, int id, CreateScreeningDto model)
        {
            Screening screeningCreated = await repository.CreateScreening(id, model);
            if(screeningCreated == null)
            {
                return TypedResults.NotFound("Id does not exist");
            }
            Payload<Screening> payload = new Payload<Screening>();
            payload.status = "success";
            payload.data = screeningCreated;
            return TypedResults.Created("", payload);
        }
    }
}
