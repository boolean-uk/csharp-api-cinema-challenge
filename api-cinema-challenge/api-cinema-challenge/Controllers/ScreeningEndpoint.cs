using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.User_Requests;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Payloads;
using workshop.wwwapi.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("cinema/screenings");

            screeningGroup.MapGet("", GetScreenings);
            screeningGroup.MapPost("", CreateScreening);
        }

        // --- Screening ---
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository)
        {
            Payload<IEnumerable<ScreeningDTO>> payload = new();

            // Create DTO
            List<ScreeningDTO> cDTO = (await repository.GetAll())
                    .Select(entity => new ScreeningDTO(entity)).ToList();
            payload.data = cDTO;

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, ScreeningRequest request)
        {
            Payload<ScreeningDTO> payload = new();
            Screening entity = new Screening(request); 

            entity = await repository.Insert(entity);

            // Create DTO
            payload.data = new ScreeningDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
    }
}
