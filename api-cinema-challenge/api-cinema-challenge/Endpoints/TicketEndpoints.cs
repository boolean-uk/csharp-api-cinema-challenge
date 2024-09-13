using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class TicketEndpoints
    {
        public static void ConfigureTicketEndpoints(this WebApplication app)
        {
            var tickets = app.MapGroup("tickets");

            tickets.MapPost("/customers/{id}", CreateTicket);
            tickets.MapGet("/", GetTickets);
            tickets.MapGet("/screenings/{id}", GetTicketsByScreening);
            tickets.MapGet("/{id}", GetTicketById);
            tickets.MapDelete("/{id}", DeleteTicket);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateTicket(ITicketRepository TicketRepository, IScreeningRepository screeningRepository, ICustomerRepository customerRepository, PostTicketDTO model)
        {
            try
            {
                var targetCustomer = await customerRepository.GetCustomerById(model.CustomerId);
                if (targetCustomer == null)
                {
                    return TypedResults.NotFound("Related customer not found");
                }

                var targetScreening = await screeningRepository.GetScreeningById(model.ScreeningId);
                if (targetScreening == null)
                {
                    return TypedResults.NotFound("Related screening not found");
                }

                var newTicket = await TicketRepository.CreateTicket(new Ticket()
                {
                    NumSeats = model.NumSeats,
                    CustomerId = model.CustomerId,
                    ScreeningId = model.ScreeningId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });

                Payload<ResponseTicketDTO> payload = new Payload<ResponseTicketDTO>();
                payload.data = Mapper.MapToDTO(newTicket);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Created($"https://localhost:7054/tickets/{payload.data.Id}", payload);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid Ticket object");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetTickets(ITicketRepository repository)
        {
            var results = await repository.GetTickets();
            List<Ticket> Tickets = results.ToList();
            if (Tickets.Count <= 0)
            {
                return TypedResults.NoContent();
            }

            Payload<List<ResponseTicketDTO>> payload = new Payload<List<ResponseTicketDTO>>();
            List<ResponseTicketDTO> responseTickets = new List<ResponseTicketDTO>();

            foreach (Ticket t in Tickets)
            {
                responseTickets.Add(Mapper.MapToDTO(t));
            }

            payload.data = responseTickets;
            payload.status = System.Net.HttpStatusCode.OK;

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTicketsByScreening(ITicketRepository repository, int id)
        {
            try
            {
                var result = await repository.GetTicketsByScreening(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Related screening not Found");
                }

                Payload<List<ResponseTicketDTO>> payload = new Payload<List<ResponseTicketDTO>>();
                List<ResponseTicketDTO> responseTickets = new List<ResponseTicketDTO>();

                foreach (Ticket t in result)
                {
                    responseTickets.Add(Mapper.MapToDTO(t));
                }
                payload.data = responseTickets;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTicketById(ITicketRepository repository, int id)
        {
            try
            {
                var result = await repository.GetTicketById(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Ticket Not Found");
                }

                Payload<ResponseTicketDTO> payload = new Payload<ResponseTicketDTO>();
                payload.data = Mapper.MapToDTO(result);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteTicket(ITicketRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteTicket(id);

                Payload<ResponseTicketDTO> payload = new Payload<ResponseTicketDTO>();
                payload.data = Mapper.MapToDTO(target);
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
