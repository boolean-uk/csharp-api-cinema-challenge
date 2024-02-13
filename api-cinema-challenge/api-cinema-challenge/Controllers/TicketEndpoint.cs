using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.User_Requests;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Payloads;
using workshop.wwwapi.Repository;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var TicketGroup = app.MapGroup("cinema/tickets");

            TicketGroup.MapGet("", GetTickets);
            TicketGroup.MapPost("", CreateTicket);
        }

        // --- Ticket ---
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository)
        {
            Payload<IEnumerable<TicketDTO>> payload = new();

            // Create DTO
            List<TicketDTO> DTO = (await repository.GetAll())
                    .Select(entity => new TicketDTO(entity)).ToList();
            payload.data = DTO;

            // Send DTO
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, IRepository<Customer> repositoryCustomer, IRepository<Screening> repositoryScreenings, TicketRequest request)
        {
            Payload<TicketDTO> payload = new();

            // FK validity check
            if (repositoryCustomer.GetByID(request.FK_Id_Customer).Result == default(Customer) ||
                repositoryScreenings.GetByID(request.FK_Id_Screening).Result == default(Screening))
                return TypedResults.NotFound("Object with specified foreign key was not found");

            // Create Entity
            Ticket entity = new Ticket(request);
            if (entity == default(Ticket))
                return TypedResults.BadRequest();

            // Insert object into database
            entity = await repository.Insert(entity);

            // Create DTO
            payload.data = new TicketDTO(entity);

            // Send DTO
            return TypedResults.Ok(payload);
        }
    }
}
