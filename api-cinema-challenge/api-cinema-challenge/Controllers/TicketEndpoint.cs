using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {
       public static void ConfigureTicketEndpoint(this WebApplication app)
        {

            app.MapGet("customers/{customerId}/screenings/{screeningId}", GetTickets);
            app.MapPost("customers/{customerId}/screenings/{screeningId}", CreateTicket);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, 
            IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, 
            int customerId, int screeningId)
        {
            Customer customer = await customerRepository.Get(customerId);
            Screening screening = await screeningRepository.Get(screeningId);
            if (customer == null || screening == null) return TypedResults.NotFound();

            List<Ticket> ticketList = customer.Tickets.Intersect(screening.Tickets).ToList();

            if (!ticketList.Any()) return TypedResults.NotFound();
            return TypedResults.Ok(new Payload<List<Ticket>>(ticketList));
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, 
            IRepository<Customer> cusomterRepository, IRepository<Screening> screeningRepository, 
            TicketDto ticketDto, int customerId, int screeningId)
        {
            if (await cusomterRepository.Get(customerId) == null ||
                 await screeningRepository.Get(screeningId) == null)
                return TypedResults.NotFound();

            Ticket ticket = Service.TicketService.toTicket(ticketDto, customerId, screeningId);
            Ticket result = await repository.Create(ticket);
            return TypedResults.Created($"cusomter/{result.Id}", new Payload<Ticket>(result));
        }
    }
}
