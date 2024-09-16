using api_cinema_challenge.DTOs;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class TicketEndpoint
    {

        public static void ConfigureTicetsEndpoint(this WebApplication app)
        {
            var ticket = app.MapGroup("tickets");
            ticket.MapPost("/", AddTicket);
            ticket.MapGet("/", GetTicket);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddTicket(IRepository repository, int screeningId)
        {
            try
            {
                var ticket = await repository.AddTicket(screeningId);
                return ticket != null ? TypedResults.Ok(ticket) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicket(IRepository repository)
        {
            try
            {
                var ticket = await repository.GetTicket();
                return ticket != null ? TypedResults.Ok(ticket) : TypedResults.NotFound("NotFound");
            }
            catch (Exception ex)
            {
                using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
                ILogger logger = factory.CreateLogger("Errors");
                logger.LogInformation(ex.ToString());

                return TypedResults.BadRequest("Bad Request");
            }
        }
    }
}
