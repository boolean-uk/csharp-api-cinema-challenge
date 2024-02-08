using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels.Customers;
using api_cinema_challenge.Models.TransferModels.Payload;
using api_cinema_challenge.Models.TransferModels.Tickets;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

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

            customerGroup.MapGet("{customerId}/tickets/", GetAllCustomerTickets);
            customerGroup.MapGet("{customerId}/screenings/{screeningId}", GetTicketForScreeningForCustomer);
            customerGroup.MapPost("{customerId}/screenings/{screeningId}", PostTicketForCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomers (IRepository<Customer> repo) 
        {
            IEnumerable<Customer> customers = await repo.GetAll();

            IEnumerable<CustomerDTO> customersOut = customers.OrderBy(c => c.CustomerId).Select(c => new CustomerDTO(c.CustomerId, c.CustomerName, c.Email, c.PhoneNumber, c.CreatedAt, c.UpdatedAt));
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

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> PostCustomer(IRepository<Customer> repo, CustomerInputDTO customerPost)
        {

            Customer inputCustomer = new Customer()
            {
                CustomerName = customerPost.Name,
                Email = customerPost.Email,
                PhoneNumber = customerPost.Phone,
                CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
            };
            Customer customer = await repo.Insert(inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Created($"/{customerOut.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
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
                CustomerId = customer.CustomerId,
                CustomerName = customerPost.Name ?? customer.CustomerName,
                Email = customerPost.Email ?? customer.Email,
                PhoneNumber = customerPost.Phone ?? customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
            };
            
            customer = await repo.Update(id, inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Created($"/{customerOut.Id}", payload);
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
        private static async Task<IResult> GetAllCustomerTickets(IRepository<Customer> repo, int customerId)
        {
            Customer? customer = await repo.GetIncluding(customerId, "CustomerId", (c => c.Tickets));
            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {customerId} found.");
            }
            IEnumerable<Ticket> tickets = customer.Tickets;

            IEnumerable<TicketDTO> ticketsOut = tickets.Select(t => new TicketDTO(t.TicketId, t.NumberOfSeats, t.CreatedAt, t.UpdatedAt));
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>(ticketsOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetTicketForScreeningForCustomer(IRepository<Customer> customerRepo, int customerId, int screeningId)
        {
            Customer? customer = await customerRepo.GetIncluding(customerId, "CustomerId", (c => c.Tickets));
            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {customerId} found.");
            }

            Ticket? ticket = customer.Tickets.Where(t => t.ScreeningId == screeningId).FirstOrDefault();
            if (ticket == null) 
            {
                return TypedResults.NotFound($"No ticket with screening ID {screeningId} found.");
            }


            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.NumberOfSeats, ticket.CreatedAt, ticket.UpdatedAt);
            Payload<TicketDTO> payload = new Payload<TicketDTO>(ticketOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PostTicketForCustomer(IRepository<Customer> customerRepo, IRepository<Screening> screeningRepo, IRepository<Ticket> ticketRepo, int customerId, int screeningId, TicketInputDTO ticketPost)
        {
            // VALIDATE THE DATA
            Customer? customer = await customerRepo.GetIncluding(customerId, "CustomerId", (c => c.Tickets));
            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {customerId} found.");
            }

            Screening? screening = await screeningRepo.GetIncluding(screeningId, "ScreeningId", (s => s.Tickets));
            if (screening == null)
            {
                return TypedResults.NotFound($"No screening with ID {screeningId} found.");
            }

            int seatsAvailable = screening.Display.Capacity - screening.Tickets.Sum(t => t.NumberOfSeats);
            if (seatsAvailable < ticketPost.numSeats) 
            {
                return TypedResults.BadRequest($"The provided screening only has {seatsAvailable} seats left, therefore you were denied your purchase of {ticketPost.numSeats} seats.");
            }

            // DATA OK
            // GENERATING AND INSERTING TICKET
            Ticket inputTicket = new Ticket()
            {
                NumberOfSeats = ticketPost.numSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc)
            };
            Ticket ticket = await ticketRepo.Insert(inputTicket);

            TicketDTO ticketOut = new TicketDTO(ticket.TicketId, ticket.NumberOfSeats, ticket.CreatedAt, ticket.UpdatedAt);
            Payload<TicketDTO> payload = new Payload<TicketDTO>(ticketOut);
            return TypedResults.Created($"/{ticketOut.Id}", payload);
        }
    }
}
