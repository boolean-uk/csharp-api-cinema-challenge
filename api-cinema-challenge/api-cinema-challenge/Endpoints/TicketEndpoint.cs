using api_cinema_challenge.Models.Base;
using api_cinema_challenge.Models.InputDTOs;
using api_cinema_challenge.Models.OutputDTOs;
using api_cinema_challenge.Repository.GenericRepository;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            app.MapGet("/customers/{customerId}/screenings", GetTickets);
            app.MapGet("/customers/{customerId}/screenings/{screeningId}", GetTicketById);
            app.MapPost("/customers/{customerId}/screenings/{screeningId}", CreateTicket);
        }

        private static async Task<IResult> CreateTicket
            (
            IRepository<Customer> customerRepo,
            IRepository<Ticket> ticketRepo,
            IRepository<Screening> screeningRepo,
            int customerId,
            int screeningId,
            TicketInputDto inputDto
            )
        {
            var screening = await screeningRepo.GetById(screeningId);
            var customer = await customerRepo.GetById(customerId);

            var ticket = new Ticket
            {
                NumSeats = inputDto.NumSeats,
                CustomerId = customerId,
                Customer = customer,
                ScreeningId = screeningId,
                Screening = screening,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,

            };

            var inserted = await ticketRepo.Insert(ticket);
            return TypedResults.Created($"/customers/{{customerId}}/screenings/{{screeningId}}", new Payload<object>().Get(TicketOutputDto.Create(inserted)));
        }

        private static async Task<IResult> GetTickets(IRepository<Ticket> repo, int customerId)
        {
            var tickets = await repo.Get();
            var customerTickets = tickets.Where(ticket => ticket.CustomerId == customerId);
            return Results.Ok(new Payload<object>().Get(customerTickets.Select(TicketOutputDto.Create)));
        }

        private static async Task<IResult> GetTicketById(IRepository<Ticket> repo, int screeningId, int customerId)
        {
            var ticket = await repo.GetById(screeningId, customerId);
            if (ticket == null) return Results.NotFound();
            return Results.Ok(new Payload<object>().Get(TicketOutputDto.Create(ticket)));
            
        }
        
    }

}
