using api_cinema_challenge.DTOs.Custommer;
using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ServiceResponse;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreenningsEndpoints
    {
        public static void ConfigureScreenningsEndpoint(this WebApplication app)
        {
            var screenGroup = app.MapGroup("custommers");

            screenGroup.MapGet("/", GetCustommers);
            //screenGroup.MapPost("/", CreateCustommer);
            



        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustommers(IRepository repository)
        {

            //Soruce:
            var source = await repository.GetCustommers();

            //Target & Transferring:

            List<OutCustommerDTO> outData = source.Select(c => new OutCustommerDTO
            {
                Id = c.Id,
                Email = c.Email,
                Name = c.Name,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
                Tickets = c.Tickets.Select(t => new OutTicketDTO { Id = t.Id, CreatedAt = t.CreatedAt, UpdatedAt = t.UpdatedAt, SeatNumber = t.SeatNumber }).ToList()

            }).ToList();

            // Use the wrapper class to create a consisten response:
            var response = new ServiceResponse<List<OutCustommerDTO>>
            {
                Data = outData,
                Status = "Success"
            };

            return TypedResults.Ok(response);
        }


    }
}
