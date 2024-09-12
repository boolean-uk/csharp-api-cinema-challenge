using api_cinema_challenge.DTO;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Replication;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customers = app.MapGroup("customers");
            customers.MapGet("/", GetAllCustomers);
            customers.MapPost("/", CreateCustomer);
            customers.MapPut("/", UpdateCustomer);
            customers.MapDelete("/", DeleteCustomer);
            customers.MapGet("/{id}/screenings/{screeningId}", GetAllCustomerScreeningTickets);
            customers.MapPost("/{id}/screenings/{screeningId}", BookTicket);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> BookTicket(IRepository repository, TicketPostmodel ticketPost, int customerId, int screeningId)
        {
            var ticket = ticketPost.ToTicket(customerId, screeningId);
            var resultingTicket = await repository.CreateTicket(ticket);

            Payload<TicketDTO> payload = new () { Status = "success", Data = resultingTicket.ToTicketDTO() };

            return TypedResults.Created($"https://localhost:7195/customers/{customerId}/screenings/{screeningId}", payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomerScreeningTickets(IRepository repository, int customerId, int screeningId)
        {
            var tickets = await repository.GetAllTickets(customerId, screeningId);
            List<TicketDTO> ticketsDTO = (from ticket in tickets select ticket.ToTicketDTO()).ToList();

            Payload<List<TicketDTO>> payload = new() { Status = "success", Data = ticketsDTO };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            var customers = await repository.GetAllCustomers();

            var customersDTO = (from customer in customers select customer.ToCustomerDTO()).ToList();

            Payload<List<CustomerDTO>> payload = new() { Status = "success", Data = customersDTO };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel customerPost)
        {

            var customer = await repository.CreateCustomer(customerPost.ToCustomer());

            Payload<CustomerDTO> payload = new () { Status = "success", Data = customer.ToCustomerDTO() };

            return TypedResults.Created($"https://localhost:7195/customers/{customer.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerPostModel customerUpdate, int customerId)
        {
            var customer = await repository.GetACustomer(customerId);

            if (!string.IsNullOrEmpty(customerUpdate.Name)) customer.Name = customerUpdate.Name;

            if (!string.IsNullOrEmpty(customerUpdate.Email)) customer.Email = customerUpdate.Email;

            if (!string.IsNullOrEmpty(customerUpdate.Phone)) customer.Phone = customerUpdate.Phone;

            customer.UpdatedAt = DateTime.UtcNow;

            var resultingCustomer = await repository.UpdateCustomer(customer);

            Payload<CustomerDTO> payload = new() { Status = "success", Data = resultingCustomer.ToCustomerDTO() };

            return TypedResults.Created($"https://localhost:7195/customers/{resultingCustomer.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int customerId)
        {
            var customer = await repository.DeleteCustomer(customerId);

            Payload<CustomerDTO> payload = new() {Status = "success", Data=customer.ToCustomerDTO() };

            return TypedResults.Ok(payload);
        }
    }
}
