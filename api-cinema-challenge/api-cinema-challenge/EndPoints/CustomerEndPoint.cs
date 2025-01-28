using api_cinema_challenge.DTO.Request;
using api_cinema_challenge.DTO.Response;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Response;
using AutoMapper;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerEndPoint
    {
        public static void ConfigureCustomerEndPoints(this WebApplication app)
        {
            var customer = app.MapGroup("customers");

            customer.MapGet("/", GetAllCustomers);
            customer.MapPost("/", AddCustomer);
            customer.MapPut("/{customer_id}", UpdateCustomer);
            customer.MapDelete("/{customer_id}", DeleteCustomer);

            customer.MapPost("/{customer_id}/screenings/{screening_id}", AddTicket);
            customer.MapGet("/{movie_id}/screenings/{screening_id}", GetAllTickets);
        }
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            var customers = await repository.Get();
            var response = mapper.Map<List<CustomerDTO>>(customers);

            return TypedResults.Ok(new Response<List<CustomerDTO>>("Success", response));
        }
        public static async Task<IResult> AddCustomer(IRepository<Customer> repository, CustomerPost model, IMapper mapper)
        {
            Customer customer = new Customer()
            {
                name = model.name,
                email = model.email,
                phone = model.phone,
            };
            await repository.Add(customer);
            
            var response = mapper.Map<CustomerDTO>(customer);

            return TypedResults.Created($"https://localhost:7010/customers/{customer.Id}", new Response<CustomerDTO>("Success", response));
        }
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int customer_id, CustomerPut model, IMapper mapper)
        {
            var target = await repository.GetById(customer_id);
            if (target == null)
            {
                return TypedResults.NotFound("Customer not found");
            }

            if (!string.IsNullOrEmpty(model.name)) { target.name = model.name; }
            if (!string.IsNullOrEmpty(model.email)) { target.email = model.email; }
            if (!string.IsNullOrEmpty(model.phone)) { target.phone = model.phone; }

            target.updatedAt = DateTime.Now;

            await repository.Update(target);

            var response = mapper.Map<CustomerDTO>(target);

            return TypedResults.Ok(new Response<CustomerDTO>("Success", response));
        }
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int customer_id, IMapper mapper)
        {
            var target = await repository.GetById(customer_id);
            if (target == null)
            {
                return TypedResults.NotFound("Customer not found");
            }
            
            await repository.Delete(customer_id);

            var response = mapper.Map<CustomerDTO>(target);

            return TypedResults.Ok(new Response<CustomerDTO>("Success", response));
        }
        public static async Task<IResult> AddTicket(IRepository<Customer> customerRepository,
                                                        IRepository<Screening> screeningRepository,
                                                        IRepository<Ticket> ticketRepository,
                                                        int customer_id, int screening_id, TicketPost model, IMapper mapper)
        {
            var customer = await customerRepository.GetById(customer_id);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found");
            }
            var screening = await screeningRepository.GetById(screening_id);
            if (screening == null)
            {
                return TypedResults.NotFound("Screening not found");
            }
            Ticket ticket = new Ticket
            {
                numSeats = model.numSeats,
                Screening = screening,
                Customer = customer,
            };
            await ticketRepository.Add(ticket);

            var response = mapper.Map<TicketDTO>(ticket);

            return TypedResults.Ok(new Response<TicketDTO>("Success", response));
        }
        public static async Task<IResult> GetAllTickets(IRepository<Customer> customerRepository,
                                                        IRepository<Screening> screeningRepository, 
                                                        IRepository<Ticket> ticketRepository,
                                                        int customer_id, int screening_id, IMapper mapper)
        {
            var customer = await customerRepository.GetById(customer_id);
            if (customer == null)
            {
                return TypedResults.NotFound("Customer not found");
            }
            var screening = await screeningRepository.GetById(screening_id);
            if (screening == null)
            {
                return TypedResults.NotFound("Screening not found");
            }
            List<Ticket> tickets = ticketRepository.GetQueryable()
                .Where(s => s.customerId == customer_id)
                .ToList();

            if (tickets == null)
            {
                return TypedResults.NotFound($"No tickets found for customer with id:{customer_id} and id: {screening_id}");
            }

            var response = mapper.Map<List<TicketDTO>>(tickets);

            return TypedResults.Ok(new Response<List<TicketDTO>>("Success", response));
        }
    }
}
