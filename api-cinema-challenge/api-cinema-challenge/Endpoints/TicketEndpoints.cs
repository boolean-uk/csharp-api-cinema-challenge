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

            app.MapPost($"/{CustomerEndpoints.Path}/{{customerId}}/{ScreeningEndpoints.Path}/{{screeningId}}", CreateTicket);
            app.MapGet($"/{CustomerEndpoints.Path}/{{customerId}}/{ScreeningEndpoints.Path}/{{screeningId}}", GetTickets);
            group.MapGet("/{id}", GetTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTickets(
            IRepository<Ticket, int> repository, 
            IRepository<Customer, int> customerRepository, 
            IRepository<Screening, int> screeningRepository,
            IMapper mapper,
            int customerId,
            int screeningId)
        {
            try
            {
                _ = await customerRepository.Get(customerId);
                _ = await screeningRepository.Get(screeningId);
                IEnumerable<Ticket> tickets = await repository.FindAll(
                    condition: x => x.ScreeningId == screeningId && x.CustomerId == customerId,
                    includeChains: q => q.Include(x => x.Seat)
                );
                return TypedResults.Ok(new Payload { Data = mapper.Map<List<TicketView>>(tickets) });
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTicket(IRepository<Ticket, int> repository, IMapper mapper, int id)
        {
            try
            {
                Ticket ticket = await repository.Get(id,
                    q => q.Include(x => x.Seat));
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
            IRepository<Customer, int> customerRepository,
            IRepository<Screening, int> screeningRepository,
            IRepository<Seat, int> seatRepository,
            IMapper mapper,
            int customerId,
            int screeningId,
            TicketPost entity)
        {
            try
            {
                Customer customer = await customerRepository.Get(customerId);
                Screening screening = await screeningRepository.Get(screeningId, q => q.Include(x => x.Tickets));
                Seat seat = await seatRepository.Get(entity.SeatId);
                if (screening.Tickets.Any(t => t.SeatId == entity.SeatId))
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = "The provided seat is already taken!" } });

                Ticket ticket = await repository.Add(new Ticket
                {
                    SeatId = entity.SeatId,
                    Seat = seat,
                    CustomerId = customer.Id,
                    ScreeningId = screening.Id,
                });
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
