using System.Linq.Expressions;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
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

            group.MapPost($"/{CustomerEndpoints.Path}/{{customerId}}/{ScreeningEndpoints.Path}/{{screeningId}}", CreateTicket);
            group.MapGet("/{id}", GetTicket);
            group.MapGet($"/{CustomerEndpoints.Path}/{{customerId}}/{ScreeningEndpoints.Path}/{{screeningId}}",
                (IRepository<Ticket, int> repository, IMapper mapper, int customerId, int screeningId) =>
                    GetTicketsConditional(repository, mapper, x => x.CustomerId == customerId && x.ScreeningId == screeningId))
                .WithTags(typeof(TicketEndpoints).Name);
            group.MapGet($"/{CustomerEndpoints.Path}/{{customerId}}",
                (IRepository<Ticket, int> repository, IMapper mapper, int customerId) =>
                    GetTicketsConditional(repository, mapper, x => x.CustomerId == customerId))
                .WithTags(typeof(TicketEndpoints).Name);
            group.MapGet($"/{ScreeningEndpoints.Path}/{{screeningId}}",
                (IRepository<Ticket, int> repository, IMapper mapper, int screeningId) =>
                    GetTicketsConditional(repository, mapper, x => x.ScreeningId == screeningId))
                .WithTags(typeof(TicketEndpoints).Name);
            group.MapGet("/", 
                (IRepository<Ticket, int> repository, IMapper mapper) => 
                    GetTicketsConditional(repository, mapper, null))
                .WithTags(typeof(TicketEndpoints).Name);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetTicket(IRepository<Ticket, int> repository, IMapper mapper, int id)
        {
            try
            {
                Ticket ticket = await repository.Get(id,
                    q => q.Include(x => x.Seat),
                    q => q.Include(x => x.Screening).ThenInclude(x => x.Screen),
                    q => q.Include(x => x.Screening).ThenInclude(x => x.Movie)
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

        private static async Task<IResult> GetTicketsConditional(
            IRepository<Ticket, int> repository, 
            IMapper mapper,
            Expression<Func<Ticket, bool>>? condition
        )
        {
            try
            {
                IEnumerable<Ticket> ticket = await repository.FindAll(
                    condition: condition,
                    includeChains: [q => q.Include(x => x.Seat),
                    q => q.Include(x => x.Screening).ThenInclude(x => x.Screen),
                    q => q.Include(x => x.Screening).ThenInclude(x => x.Movie)]
                ); 
                return TypedResults.Ok(mapper.Map<List<TicketView>>(ticket));
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
                TicketType ticketType;
                if (!Enum.TryParse(entity.TicketType, true, out ticketType))
                    return TypedResults.BadRequest(new Payload { Status = "failure", Data = new { Message = $"That is not a valid ticket type! Choose one of {string.Join(", ", Enum.GetValues<TicketType>())}" } });

                Ticket ticket = await repository.Add(new Ticket
                {
                    SeatId = entity.SeatId,
                    Seat = seat,
                    CustomerId = customer.Id,
                    ScreeningId = screening.Id,
                    TicketType = ticketType
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
