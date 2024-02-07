using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Models.TransferModels.Customer;
using api_cinema_challenge.Models.TransferModels.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api_cinema_challenge.Controllers
{
    public static class CustomersEndpoint
    {
        public static void ConfigureCustomersEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers/");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapGet("/{id}", GetCustomer);
            customerGroup.MapPost("/", PostCustomer);
            customerGroup.MapPut("/{id}", PutCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomers (IRepository<Customer> repo) 
        {
            IEnumerable<Customer> customers = await repo.GetAll();

            IEnumerable<CustomerDTO> customersOut = customers.Select(c => new CustomerDTO(c.CustomerId, c.CustomerName, c.Email, c.PhoneNumber, c.CreatedAt, c.UpdatedAt));
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>(customersOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomer(IRepository<Customer> repo, int id)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null) 
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> PostCustomer(IRepository<Customer> repo, CustomerInputDTO customerPost)
        {

            Customer inputCustomer = new Customer()
            {
                CustomerName = customerPost.Name,
                Email = customerPost.Email,
                PhoneNumber = customerPost.Phone,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            Customer customer = await repo.Insert(inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutCustomer(IRepository<Customer> repo, int id, CustomerInputDTO customerPost)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            Customer inputCustomer = new Customer()
            {
                CustomerName = customerPost.Name ?? customer.CustomerName,
                Email = customerPost.Email ?? customer.Email,
                PhoneNumber = customerPost.Phone ?? customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = DateTime.Now
            };
            
            customer = await repo.Update(id, inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            customer = await repo.Delete(id);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTickets(IRepository<Ticket> repo)
        {
            IEnumerable<Ticket> tickets = await repo.GetAll();

            IEnumerable<TicketDTO> ticketsOut = tickets.Select(t => new TicketDTO(t.TicketId, t.NumberOfSeats, t.CreatedAt, t.UpdatedAt));
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>(ticketsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomerTicketsForScreening(IRepository<Ticket> repo, int customerId, int screeningId)
        {
            IEnumerable<Ticket> tickets = await repo.GetAll();
            tickets = tickets.Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId);
            if (tickets.Count() < 1) 
            {
                return TypedResults.NotFound($"No tickets for screening with ID {screeningId} found for the customer with ID {customerId}.");
            }

            IEnumerable<TicketDTO> ticketsOut = tickets.Select(t => new TicketDTO(t.TicketId, t.NumberOfSeats, t.CreatedAt, t.UpdatedAt));
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>(ticketsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicket(IRepository<Ticket> repo, int id)
        {
            Ticket? ticket = await repo.Get(id);

            if (ticket == null)
            {
                return TypedResults.NotFound($"No ticket with ID {id} found.");
            }

            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.NumberOfSeats, ticket.CreatedAt, ticket.UpdatedAt);
            Payload<TicketDTO> payload = new Payload<TicketDTO>(ticketOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostTicket(IRepository<Ticket> repo, int customerId, int screeningId, TicketInputDTO ticketPost)
        {

            Ticket inputTicket = new Ticket()
            {
                NumberOfSeats = ticketPost.numSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            Ticket ticket = await repo.Insert(inputTicket);

            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.NumberOfSeats, ticket.CreatedAt, ticket.UpdatedAt);
            Payload<TicketDTO> payload = new Payload<TicketDTO>(ticketOut);
            return TypedResults.Created($"/{ticketOut.Id}", payload);
        }
    }
}
