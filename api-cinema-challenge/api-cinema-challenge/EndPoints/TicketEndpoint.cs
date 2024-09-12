using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
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
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, int customerId, int screeningId, TicketView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Ticket()
            {
                CustomerId = customerId,
                ScreeningId = screeningId,
                NumSeats = view.NumSeats,
                CreatedAt = creationTime,
                UpdatedAt = creationTime
            };
            var result = await repository.Create(["Customer", "Screening"], model);
            var resultDTO = new TicketDTO(result);

            var payload = new Payload<TicketDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_basepath, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int customerId, int screeningId)
        {
            var resultList = await repository.GetAll(["Customer", "Screening"], m => m.CustomerId == customerId && m.ScreeningId == screeningId);
            var resultDTOs = new List<TicketDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new TicketDTO(result));
            }

            var payload = new Payload<List<TicketDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(payload);
        }
    }
}
