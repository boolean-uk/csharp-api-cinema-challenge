using api_cinema_challenge.Models.CustomerModels;
using api_cinema_challenge.Models.ScreeningModels;
using api_cinema_challenge.Models.TicketModels;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.Services;
using Microsoft.AspNetCore.Mvc;
using workshop.wwwapi.Models;

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
        private static async Task<IResult> GetAll(IRepository<Customer> repository)
        {
            IEnumerable<Customer> customers = await repository.Get();

            //IEnumerable<OutputCustomer> outputCustomers = CustomerDtoManager.Convert(customers);
            var payload = new Payload<IEnumerable<Customer>>(customers);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Get(int id, IRepository<Customer> repository)
        {
            Customer? customer = await repository.Get(id);
            if (customer == null)
                return TypedResults.NotFound(new Payload<Customer>(customer));

            //OutputCustomer outputCustomer = CustomerDtoManager.Convert(customer);
            var payload = new Payload<Customer>(customer);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> Create(InputCustomer customer, IRepository<Customer> repository)
        {
            Customer newCustomer = CustomerDtoManager.Convert(customer);

            Customer result = await repository.Create(newCustomer);

            //OutputCustomer outputCustomer = CustomerDtoManager.Convert(result);
            var payload = new Payload<Customer>(result);
            return TypedResults.Created("url", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Update(int id, InputCustomer inputCustomer, IRepository<Customer> repository)
        {
            Customer customerToUpdate = await repository.Get(id);
            if (customerToUpdate == null)
                return TypedResults.NotFound(new Payload<Customer>(customerToUpdate));

            customerToUpdate.UpdatedAt = DateTime.UtcNow;
            customerToUpdate.Name = inputCustomer.Name;
            customerToUpdate.Phone = inputCustomer.Phone;
            customerToUpdate.Email = inputCustomer.Email;

            Customer? result = await repository.Update(customerToUpdate);

            //OutputCustomer outputCustomer = CustomerDtoManager.Convert(result);
            var payload = new Payload<Customer>(result);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> Delete(int id, IRepository<Customer> repository)
        {
            Customer customer = await repository.Delete(id);
            if (customer == null)
                return TypedResults.NotFound(new Payload<Customer>(customer));

            //OutputCustomer outputCustomer = CustomerDtoManager.Convert(result);
            var payload = new Payload<Customer>(customer);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository<Ticket> ticketRepository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository)
        {
            Customer? customer = await customerRepository.Get(customerId);
            if (customer == null)
                return Results.NotFound($"Customer with id {customerId} not found");

            Screening? screening = await screeningRepository.Get(screeningId);
            if (screening == null)
                return Results.NotFound($"Screening with id {screeningId} not found");

            IEnumerable<Ticket> tickets = await ticketRepository.GetWhere(t => t.CustomerId == customerId && t.ScreeningId == screeningId);

            IEnumerable<OutputTicket> outputTickets = TicketDtoManager.Convert(tickets);
            var payload = new Payload<IEnumerable<OutputTicket>>(outputTickets);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateTicket(int customerId, int screeningId, InputTicket inputTicket, IRepository<Ticket> ticketRepository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository)
        {
            Customer? customer = await customerRepository.Get(customerId);
            if (customer == null)
                return Results.NotFound($"Customer with id {customerId} not found");

            Screening? screening = await screeningRepository.Get(screeningId);
            if (screening == null)
                return Results.NotFound($"Screening with id {screeningId} not found");

            Ticket newTicket = TicketDtoManager.Convert(inputTicket);
            newTicket.CustomerId = customerId;
            newTicket.ScreeningId = screeningId;

            Ticket result = await ticketRepository.Create(newTicket);

            OutputTicket outputTicket = TicketDtoManager.Convert(result);
            var payload = new Payload<OutputTicket>(outputTicket);
            return TypedResults.Created("url", payload);
        }
    }
}
