using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Diagnostics;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Model;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;

namespace api_cinema_challenge.Endpoint
{
    public static class TicketEndpoint
    {
        public static void ConfigureTicketEndpoint(this WebApplication app)
        {
            var ticketGroup = app.MapGroup("customers");
            ticketGroup.MapPost("/{customerId}/screenings/{screeningsId}", Create);
            ticketGroup.MapGet("/{customerId}/screenings/{screeningId}", Get);
            /*
            movieGroup.MapPost("/create", Create);
            movieGroup.MapPut("/update", Update);
            movieGroup.MapDelete("/delete", Delete);
            movieGroup.MapGet("/test", test);*/
        }

        public static async Task<IResult> Create(IRepository<Ticket> repository, TicketPost ticketInfo, int customerId, int screeningsId) 
        {
            Ticket ticket = new Ticket()
            {
                NumSeats = ticketInfo.NumSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                CustomerId = customerId,
                ScreeningsId = screeningsId
            };
            Ticket addedTicket = await repository.Add(ticket);
            TicketServerDto dto = new TicketServerDto()
            {
                Id = addedTicket.Id,
                NumSeats = addedTicket.NumSeats,
                CreatedAt = addedTicket.CreatedAt,
                UpdatedAt = addedTicket.UpdatedAt
            };
            Payload<TicketServerDto> payload = new Payload<TicketServerDto>()
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }
    
        public static async Task<IResult> Get(IRepository<Ticket> repository, int customerId, int screeningId) 
        {
            var tickets = await repository.Get();
            var filtered = tickets.Where(t => t.CustomerId == customerId && t.ScreeningsId == screeningId);
            var dto = filtered.Select(x => new TicketServerDto()
            {
                Id = x.Id,
                NumSeats = x.NumSeats,
                CreatedAt = x.CreatedAt,
                UpdatedAt = x.UpdatedAt
            });
            Payload<IEnumerable<TicketServerDto>> payload = new Payload<IEnumerable<TicketServerDto>>()
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }
    }
}
