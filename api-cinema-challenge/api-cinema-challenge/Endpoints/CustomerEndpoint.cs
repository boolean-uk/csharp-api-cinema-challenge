using api_cinema_challenge.DTOs.Customer;
using api_cinema_challenge.DTOs.Ticket;
using api_cinema_challenge.Factories;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.Interfaces;
using api_cinema_challenge.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            string groupName = "customers";
            string contentType = "application/json";

            var customerGroup = app.MapGroup(groupName);

            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPost("/", CreateCustomer).Accepts<CustomerPostDto>(contentType);
            customerGroup.MapPut("/{customerId}", UpdateCustomer).Accepts<CustomerPutDto>(contentType);
            customerGroup.MapDelete("/{customerId}", DeleteCustomer);

            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", BookTicket).Accepts<TicketPostDto>(contentType);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetTickets);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllCustomers(ICustomerRepository repository)
        {
            var customers = await repository.GetAllAsync();

            List<CustomerDto> dtos = new List<CustomerDto>();
            foreach (var customer in customers)
            {
                dtos.Add(CustomerFactory.DtoFromCustomer(customer));
            }

            return TypedResults.Ok(new { Status = "success", Data = dtos});
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateCustomer(ICustomerRepository repository, HttpRequest request)
        {
            CustomerPostDto inDto = await Utility.ValidateFromRequest<CustomerPostDto>(request);
            if (inDto is null)
            {
                return TypedResults.BadRequest( new { status = "failure"} );
            }

            var added = await repository.CreateCustomer(CustomerFactory.CustomerFromPostDto(inDto));
            if (added is null) 
            { 
                return TypedResults.BadRequest(new { status = "failure" }); 
            }

            var outDto = CustomerFactory.DtoFromCustomer(added);

            // TODO move to other class
            var url = $"{request.Scheme}://{request.Host}{request.Path}/{outDto.Id}";

            return TypedResults.Created(url, new {status = "success", data = outDto});
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(ICustomerRepository repository, HttpRequest request, int id)
        {
            CustomerPutDto inDto = await Utility.ValidateFromRequest<CustomerPutDto>(request);
            if (inDto is null)
            {
                return TypedResults.BadRequest(new { status = "failure" });
            }

            var entity = await repository.GetByIdAsync(id);
            if (entity is null)
            {
                return TypedResults.NotFound(new { status = "failure" });
            }

            var updated = await repository.UpdateCustomer(CustomerFactory.CustomerFromPutDto(inDto, entity));
            if (updated is null)
            {
                return TypedResults.BadRequest(new { status = "failure" });
            }


            return TypedResults.Created();
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int customerId)
        {
            var customer = await repository.DeleteCustomer(customerId);
            if (customer is null)
            {
                return TypedResults.NotFound(new { status = "failure" });
            }

            var dto = CustomerFactory.DtoFromCustomer(customer);
            return TypedResults.Ok( new { status = "success", data = dto});
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> BookTicket(ITicketRepository ticketRepository, HttpRequest request, int customerId, int screeningId)
        {
            TicketPostDto inDto = await Utility.ValidateFromRequest<TicketPostDto>(request);
            if (inDto is null)
            {
                return TypedResults.BadRequest(new { status = "failure" });
            }

            var ticket = await ticketRepository.CreateTicket(TicketFactory.TicketFromPostDto(inDto, customerId, screeningId));
            if (ticket is null)
            {
                return TypedResults.BadRequest(new { status = "failure" });
            }

            var dto = TicketFactory.DtoFromTicket(ticket);
            return TypedResults.Created();
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTickets(ITicketRepository ticketRepository, HttpRequest request, int customerId, int screeningId)
        {
            var tickets = await ticketRepository.GetByIdAsync(customerId, screeningId);
            if (tickets is null)
            {
                return TypedResults.NotFound(new { status = "failure" });
            }

            List<TicketDto> dtos = new();
            foreach (var ticket in tickets)
            {
                dtos.Add(TicketFactory.DtoFromTicket(ticket));
            }
            // TODO fix url
            var url = $"{request.Scheme}://{request.Host}{request.Path}/";
            return TypedResults.Created(url, new { status = "success", data = dtos});
        }
    }
}
