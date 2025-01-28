using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var tickets = app.MapGroup("/customers/{customerId}/screenings/{screeningId}").WithTags("Tickets"); ;

            tickets.MapPost("/", Create);
            tickets.MapGet("/", GetAll);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Ticket> repo, IMapper mapper, TicketPost model, int customerId, int screeningId)
        {
            try
            {
                var newEntity = new Ticket()
                {
                    NumSeats = model.NumSeats,
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var createdEntity = await repo.Insert(newEntity);
                var dto = mapper.Map<TicketDTO>(createdEntity);

                var payload = new Payload<TicketDTO>
                {
                    Status = "success",
                    Data = dto
                };
                return TypedResults.Created($"/{createdEntity.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        /*
         * Get all tickets for a customer
         */
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Ticket> repo, IMapper mapper, int customerId, int screeningId)
        {
            try
            {
                var entities = await repo.GetWithNestedIncludes(
                    query => query
                    .Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId)
                    .Include(t => t.Customer)
                    .Include(t=>t.Screening));
                var dtos = mapper.Map<List<TicketDTO>>(entities);
                var payload = new Payload<List<TicketDTO>>();
                payload.Status = "success";
                payload.Data = dtos;
                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
