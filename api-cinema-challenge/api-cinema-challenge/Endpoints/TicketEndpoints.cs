using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static string Path { get; private set; } = "tickets";
        public static void ConfigureTicketsEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapGet("/", GetTickets);
            group.MapPost("/", CreateTicket);
            group.MapGet("/{id}", GetTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTickets(IRepository<Ticket, int> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Ticket> tickets = await repository.GetAll(
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Screening).ThenInclude(x => x.Movie),
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Screening).ThenInclude(x => x.Screen),
                    //q => q.Include(x => x.Tickets.Where(t => t.Screening.StartingAt > DateTime.UtcNow)).ThenInclude(x => x.Seat)
                );
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<TicketView>>(tickets) });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTicket(IRepository<Ticket, int> repository, IMapper mapper, int id)
        {
            try
            {
                Ticket ticket = await repository.Get(id
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Screening).ThenInclude(x => x.Movie),
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Screening).ThenInclude(x => x.Screen),
                    //q => q.Include(x => x.Tickets).ThenInclude(x => x.Seat)
                );
                return TypedResults.Ok(mapper.Map<TicketView>(ticket));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateTicket(
            IRepository<Ticket, int> repository,
            IRepository<Ticket, int> ticketRepository,
            IMapper mapper,
            TicketPost entity)
        {
            try
            {
                Ticket ticket = await repository.Add(new Ticket
                {

                });
                ticket = await ticketRepository.Add(ticket);
                return TypedResults.Created($"{Path}/{ticket.Id}", new Payload
                {
                    Data = mapper.Map<TicketView>(ticket)
                });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new Payload { Status = "failure", Data = new { ex.Message } });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
