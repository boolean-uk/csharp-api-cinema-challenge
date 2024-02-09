using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.PostModels;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using api_cinema_challenge.Models.DTO;
using NuGet.Protocol.Plugins;

namespace api_cinema_challenge.Controllers
{

    public static class TicketEndpoint {

        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
           app.MapGet("customers/{customerId}/screenings/{screeningId}", GetTickets);
           app.MapPost("customers/{customerId}/screenings/{screeningId}", BookTickets);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> ticketRepository, IRepository<Customer> customerRepository, int customerId, int screeningId)
        {
            DTO result = new DTO();
           // Customer customer = await customerRepository.GetById(customerId);
            var tickets = await ticketRepository.GetByCompositeId(screeningId, customerId);
           
                result.createDtTicket(tickets);
            
            
            PayLoad<DtTicket> payLoad = new PayLoad<DtTicket>(result.Ticket);
            
           
            return TypedResults.Ok(payLoad);
        }
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> BookTickets(IRepository<Ticket> repository, PMTicket model, int customerId, int screeningId)
        {
            DTO dto = new DTO();
            
            Ticket ticket = await repository.Insert( new Ticket() {CustomerId=customerId, ScreeningId = screeningId, NumSeats= model.NumSeats });
            dto.createDtTicket(ticket);
            PayLoad<DtTicket> load = new PayLoad<DtTicket>(dto.Ticket);
     
            return TypedResults.Created($"/{load.data}", load);


        }

    }
}
