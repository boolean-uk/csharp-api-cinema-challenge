
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerAPI
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var CustomerGroup = app.MapGroup("/customers");

            CustomerGroup.MapGet("", GetCustomers);
            CustomerGroup.MapPost("", CreateCustomer);
            CustomerGroup.MapPut("/{id}", UpdateCustomer);
            CustomerGroup.MapDelete("/{id}", DeleteCustomer);

            CustomerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetCustomerTickets);
            CustomerGroup.MapPost("/{customerId}/screenings/{screeningId}", BookTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            var customers = await repository.Get();
            List<CustomerGet> customerlist = mapper.Map<List<CustomerGet>>(customers);
            ApiResponse<List<CustomerGet>> response = new ApiResponse<List<CustomerGet>>(customerlist);
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateCustomer(IRepository<Customer> repository, IMapper mapper, CustomerPost model)
        {
            if (model == null) TypedResults.NotFound(new ApiResponse<string>("Invalid information given."));
            Customer customer = await repository.Insert(mapper.Map<Customer>(model));
            return TypedResults.Ok(new ApiResponse<CustomerGet>(mapper.Map<CustomerGet>(customer)));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, IMapper mapper, int id, CustomerPut model)
        {
            if (model == null) return TypedResults.NotFound(new ApiResponse<string>("Invalid information given."));
            Customer? customer = await repository.GetById(id);
            if (customer == null) return  TypedResults.NotFound(new ApiResponse<string>("No customer with Id"));

            if (!string.IsNullOrWhiteSpace(model.Name)) customer.Name = model.Name;
            if (!string.IsNullOrWhiteSpace(model.Email)) customer.Email = model.Email;
            if (!string.IsNullOrWhiteSpace(model.Phone)) customer.Phone = model.Phone;

            Customer updatedCustomer = await repository.Update(customer);
            CustomerGet customerDTO = mapper.Map<CustomerGet>(updatedCustomer);
            return TypedResults.Created($"/customers/{customerDTO.Id}", new ApiResponse<CustomerGet>(customerDTO));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, IMapper mapper, int id)
        {
            var result = await repository.Delete(id);
            return result != null ? TypedResults.Ok(new ApiResponse<CustomerGet>(mapper.Map<CustomerGet>(result))) : TypedResults.NotFound("Not valid ID");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomerTickets(IRepository<Ticket> repository, IMapper mapper, int customerId, int screeningId)
        {
            var tickets = await repository.Get(t => t.CustomerId == customerId && t.ScreeningId == screeningId);
            return TypedResults.Ok(new ApiResponse<List<TicketGet>>(mapper.Map<List<TicketGet>>(tickets)));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> BookTicket(IRepository<Ticket> repository, IMapper mapper, int customerId, int screeningId, TicketPost model)
        {
            if (model == null || model.NumSeats <= 0) TypedResults.NotFound(new ApiResponse<string>("Need to give a number bigger than 0."));
            Ticket ticket = mapper.Map<Ticket>(model);
            ticket.ScreeningId = screeningId;
            ticket.CustomerId = customerId;
            ticket = await repository.Insert(ticket);
            return TypedResults.Ok(new ApiResponse<TicketGet>(mapper.Map<TicketGet>(ticket)));
        }
    }
}
