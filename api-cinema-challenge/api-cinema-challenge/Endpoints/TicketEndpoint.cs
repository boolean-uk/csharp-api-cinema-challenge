using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Reflection.Metadata.BlobBuilder;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketApi
    {
        public static void ConfigureTicketApi(this WebApplication app)
        {
            app.MapGet("/tickets/{customerid}/{screeningid}", GetAllTickets);
            app.MapPost("/tickets", CreateTicket);
        }

        private static async Task<IResult> CreateTicket(ITicketRepository ticketRepository, ICustomerRepository customerRepository, IScreeningRepository screeningRepository, TicketsPostPayload ticketsPostPayload)
        {
            Customer? customer = await customerRepository.GetCustomerById(ticketsPostPayload.customerid);
            Screening? screening = await screeningRepository.GetScreeningById(ticketsPostPayload.screeningid);
            if (customer == null || screening == null)
            {
                return TypedResults.NotFound("screeningid or movieid does not exist");
            }
            Ticket ticket = await ticketRepository.CreateTicket(ticketsPostPayload.customerid, ticketsPostPayload.screeningid, ticketsPostPayload.numSeats);
            return TypedResults.Created("created", ticket);
        }

        private static async Task<IResult> GetAllTickets(ITicketRepository ticketRepository, int customerid, int screeningid)
        {
            if (customerid.GetType() != typeof(int) || screeningid.GetType() != typeof(int))
            {
                return TypedResults.BadRequest("customer and screening ids must be of type int");
            }
            IEnumerable<Ticket> output = await ticketRepository.GetAllTickets(customerid, screeningid);
            if (output == null || output.Count() == 0)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(output);
        }

    }
}
