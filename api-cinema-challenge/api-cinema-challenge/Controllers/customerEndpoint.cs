using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.TicketModels;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class customerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("customers");

            group.MapGet("", GetAll);
            group.MapGet("{id}", Get);
            group.MapPost("", Create);
            group.MapPut("{id}", Update);
            group.MapDelete("{id}", Delete);
            group.MapGet("{customerId}/screenings/{screeningId}", GetTickets);
            group.MapPost("{customerId}/screenings/{screeningId}", CreateTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IEnumerable<Customer>> GetAll(IRepository<Customer> repository)
        {
            return await repository.Get();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Customer> Get(int id, IRepository<Customer> repository)
        {
            return await repository.Get(id);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<Customer> Create(InputCustomer customer, IRepository<Customer> repository)
        {
            Customer newCustomer = CustomerDtoManager.Convert(customer); 
            return await repository.Create(newCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Customer> Update(int id, InputCustomer inputCustomer, IRepository<Customer> repository)
        {
            Customer customerToUpdate = await repository.Get(id);

            customerToUpdate.UpdatedAt = DateTime.UtcNow;
            customerToUpdate.Name = inputCustomer.Name;
            customerToUpdate.Phone = inputCustomer.Phone;
            customerToUpdate.Email = inputCustomer.Email;

            Customer? result = await repository.Update(customerToUpdate);
            return result;
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<Customer> Delete(int id, IRepository<Customer> repository)
        {
            return await repository.Delete(id);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository<Ticket> repository)
        {
            IEnumerable<Ticket> tickets = await repository.GetWhere(t => t.CustomerId == customerId && t.ScreeningId == screeningId);

            IEnumerable<OutputTicket> outputTickets = TicketDtoManager.Convert(tickets);
            return TypedResults.Ok(outputTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateTicket(int customerId, int screeningId, InputTicket inputTicket, IRepository<Ticket> repository)
        {
            Ticket newTicket = TicketDtoManager.Convert(inputTicket);
            newTicket.CustomerId = customerId;
            newTicket.ScreeningId = screeningId;

            Ticket result = await repository.Create(newTicket);

            OutputTicket outputTicket = TicketDtoManager.Convert(result);
            return TypedResults.Created("url", outputTicket);
        }
    }
}
