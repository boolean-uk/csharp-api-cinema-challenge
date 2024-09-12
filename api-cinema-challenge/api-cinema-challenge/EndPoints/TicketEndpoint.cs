using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class TicketEndpoint
    {
        // Base path of the api, used for the created call...
        private static string _basepath = AppDomain.CurrentDomain.BaseDirectory;
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticket = app.MapGroup("customers/{customerId}/screenings/{screeningId}");

            ticket.MapPost("", CreateTicket);
            ticket.MapGet("", GetTickets);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Screening> repository, int id, ScreeningView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Screening()
            {
                MovieId = id,
                ScreenId = view.ScreenNumber,
                Capacity = view.Capacity,
                StartsAt = DateTime.Parse(view.StartsAt).ToUniversalTime(),
                CreatedAt = creationTime,
                UpdatedAt = creationTime
            };
            var result = await repository.Create(["Movie"], model);
            var resultDTO = new ScreeningDTO(result);

            var payload = new Payload<ScreeningDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_basepath, resultDTO);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Screening> repository, int id)
        {
            var resultList = await repository.GetAll(["Movie"], s => s.MovieId == id);
            var resultDTOs = new List<ScreeningDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new ScreeningDTO(result));
            }

            var payload = new Payload<List<ScreeningDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(resultDTOs);
        }
    }
}
