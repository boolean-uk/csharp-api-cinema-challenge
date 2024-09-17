using api_cinema_challenge.DTO;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var ScreeningGroup = app.MapGroup("/Screenings");

            ScreeningGroup.MapPost("/Create", CreateScreening);
            
        }

        private static async Task<IResult> CreateScreening(IScreening<Screening> repository, PostScreeningDTO ScreeningDTO)
        {
            Screening Screening = Transfer.PostScreening(ScreeningDTO);
            var entity = await repository.CreateEntity(Screening);

            Payload<Screening> payload = new();

            if (!(ScreeningDTO == default(PostScreeningDTO)))
            {
                payload.load = Screening;
                payload.Status = "Success";
            }
            else
            {
                payload.load = Screening;
            }
            return TypedResults.Created();
        }

    }
}
