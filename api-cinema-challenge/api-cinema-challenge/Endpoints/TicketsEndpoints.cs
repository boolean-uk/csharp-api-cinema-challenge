using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketsEndpoints
    {
        public static void ConfigureTickets(this WebApplication app)
        {
            var customers = app.MapGroup("/customers/{customerId}/screenings/{screeningId}");

            customers.MapPost("/", Insert);
            customers.MapGet("/", GetAll);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Insert(IRepository<Ticket> repository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, IMapper mapper, int customerId, int screeningId, TicketPostDTO ticket)
        {
            try
            {
                var customerTarget = await customerRepository.GetById(customerId);
                if (customerTarget == null)
                    return TypedResults.NotFound($"Customer with id {customerId} does not exist.");
                
                var screeningTarget = await screeningRepository.GetById(screeningId);
                if (screeningTarget == null)
                    return TypedResults.NotFound($"Screening with id {screeningId} does not exist.");

                Ticket insert = new Ticket()
                {
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    numSeats = ticket.numSeats
                };

                await repository.Insert(insert);

                var insertDTO = mapper.Map<TicketDTO>(insert);

                return TypedResults.Created($"https://localhost:7195/tickets/{insert.Id}", insertDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAll(IRepository<Ticket> repository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, IMapper mapper, int customerId, int screeningId)
        {
            try
            {
                var customerTarget = await customerRepository.GetById(customerId);
                if (customerTarget == null)
                    return TypedResults.NotFound($"Customer with id {customerId} does not exist.");

                var screeningTarget = await screeningRepository.GetById(screeningId);
                if (screeningTarget == null)
                    return TypedResults.NotFound($"Screening with id {screeningId} does not exist.");

                var tickets = repository.Get().Result.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId);

                var response = mapper.Map<List<TicketDTO>>(tickets);

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
