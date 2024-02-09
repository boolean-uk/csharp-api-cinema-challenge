using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Post;
using api_cinema_challenge.Models.Types;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class TicketEndpoint
{
    public static void ConfigureTicketEndpoint(this WebApplication app)
    {
        var ticketGroup = app.MapGroup("Tickets");

        ticketGroup.MapPost("/{customerId}/screenings/{screeningId}", CreateTicket);
        ticketGroup.MapGet("/{customerId}/screenings/{screeningId}", GetTickets);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository,
            int customerId, int screeningId, PostTicket ticket)
    {
        var customer = await customerRepository.GetById(customerId);
        if (customer == null)
        {
            return TypedResults.NotFound(new Payload<string>() { Status = "fail", Data = "Customer not found!" });
        }
        var screening = await screeningRepository.GetById(screeningId);
        if (screening == null)
        {
            return TypedResults.NotFound(new Payload<string>() { Status = "fail", Data = "Screening not found!" });
        }
        var allTickets = await repository.GetAll();
        var alreadyExists = allTickets.FirstOrDefault(t => t.NumSeats == ticket.NumSeats && t.ScreeningId == screeningId);
        if (alreadyExists != null)
        {
            return TypedResults.BadRequest(new Payload<string>() { Status = "fail", Data = $"Seat has already been reserved!" });
        }
        if (ticket.NumSeats > screening.Capacity || ticket.NumSeats < 1)
        {
            return TypedResults.BadRequest(new Payload<string>() { Status = "fail", Data = $"Seat must be between minimum 1 and maximum {screening.Capacity}!" });
        }
        var newTicket = new Ticket()
        {
            CustomerId = customerId,
            Customer = customer,
            ScreeningId = screeningId,
            Screening = screening,
            NumSeats = ticket.NumSeats,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
        };
        var result = await repository.Create(newTicket);
        return TypedResults.Created($"/{result.Id}", new Payload<TicketDTO>() { Data = TicketDTO.ToDTO(result) });
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int customerId, int screeningId)
    {
        var allTickets = await repository.GetAll();
        var result = allTickets.Where(x => x.CustomerId == customerId && x.ScreeningId == screeningId).ToList();
        var returnList = new List<TicketDTO>();
        foreach (var screening in result)
        {
            returnList.Add(TicketDTO.ToDTO(screening));
        }
        return TypedResults.Ok(new Payload<List<TicketDTO>>() { Data = returnList });
    }
}
