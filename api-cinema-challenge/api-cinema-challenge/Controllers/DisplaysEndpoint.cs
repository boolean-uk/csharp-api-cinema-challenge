using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Displays;
using api_cinema_challenge.Models.TransferModels.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class DisplaysEndpoint
    {
        public static void ConfigureDisplaysEndpoint(this WebApplication app) 
        {
            var DisplaysGroup = app.MapGroup("displays/");

            DisplaysGroup.MapGet("/", GetAllDisplays);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllDisplays(IRepository<Display> repo) 
        {
            IEnumerable<Display> displays = await repo.GetAllIncluding();

            if (displays.Count() < 1) 
            {
                return TypedResults.NotFound("No displays found.");
            }

            IEnumerable<DisplayDTO> displaysOut = displays.OrderBy(d => d.Capacity).Select(d => new DisplayDTO(d.DisplayId, d.ScreenNumber, d.Capacity, d.CreatedAt, d.UpdatedAt, d.Screenings)).ToList();
            Payload<IEnumerable<DisplayDTO>> payload = new Payload<IEnumerable<DisplayDTO>>(displaysOut);
            return TypedResults.Ok(payload);
        }
    }
}
