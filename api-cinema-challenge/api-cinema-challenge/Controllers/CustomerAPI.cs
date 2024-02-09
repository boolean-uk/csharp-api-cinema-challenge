using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerAPI
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");
            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapGet("/{id}", GetCustomerById);
            customerGroup.MapDelete("/{id}", DeleteCustomerById);
            customerGroup.MapPost("/{id}/screenings/{screeningId}", BookTicket);
            customerGroup.MapGet("/{id}/screenings/{screeningId}", GetTickets);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int id, int screeningId)
        {
            var response = await repository.GetTicketsByCustomerAndScreeningId(id, screeningId);
            if (response.Count() > 0)
            {
                List<TicketDTO> tickets = new List<TicketDTO>();
                foreach(var ticket in response)
                {
                    tickets.Add(new TicketDTO(ticket));
                }
                return TypedResults.Ok(new Payload<List<TicketDTO>> { Data = tickets });
            }
            return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "No tickets found" });
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> BookTicket(IRepository<Ticket> ticketRepository, IRepository<Screening> screeningRepository, IRepository<Customer> customerRepository, int id, int screeningId, [FromBody] int numberOfSeats)
        {
            var ticket = new Ticket
            {
                NumberOfSeats = numberOfSeats,
                CustomerId = id,
                ScreeningId = screeningId,
                CreatedAt = DateTime.UtcNow
            };
            var customer = await customerRepository.GetById(ticket.CustomerId);
            if (customer == null)
            {
                return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "Customer does not exist"});
            }
            var screening = await screeningRepository.GetById(ticket.ScreeningId);
            if (screening == null)
            {
                return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "Screening does not exist" });
            }
            var response = await ticketRepository.Insert(ticket);
            if (response != null)
            {
                return TypedResults.Created("", new Payload<TicketDTO> { Data = new TicketDTO(response) });
            }
            return TypedResults.BadRequest(new Payload<string> { Status = "Failure", Data = "Could not create ticket" });
        }
    
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var response = await repository.GetAll();
            List<CustomerDTO> customers = new List<CustomerDTO>();
            if (response.Count() > 0)
            {
                foreach (var customer in response)
                {
                    customers.Add(new CustomerDTO(customer));
                    
                }
                return TypedResults.Ok(new Payload<List<CustomerDTO>> { Data = customers });
            }
            else return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "No customers" });
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerPost customer)
        {
            // Turn customerpost into customer before adding to db
            var c = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = DateTime.UtcNow,
            };
            var response = await repository.Insert(c);
            if (response != null)
            {
                return TypedResults.Created("", new Payload<CustomerDTO> { Data = new CustomerDTO(response) });
            }
            else return TypedResults.BadRequest(new Payload<string> { Status = "Failure", Data = "Could not create customer"});
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerPost customer)
        {
            var originalCustomer = await repository.GetById(id);
            if (originalCustomer == null)
            {
                return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "Customer does not exist" });
            }

            originalCustomer.Name = (customer.Name != "string" && customer.Name != null) ? customer.Name : originalCustomer.Name;
            originalCustomer.Email = (customer.Email != "string" && customer.Email != null) ? customer.Email : originalCustomer.Email;
            originalCustomer.Phone = (customer.Phone != "string" && customer.Phone != null) ? customer.Phone : originalCustomer.Phone;
            originalCustomer.UpdatedAt = DateTime.UtcNow;
            
            var response = await repository.Update(originalCustomer);
            if (response != null)
            {
                return TypedResults.Created("", new Payload<CustomerDTO> { Data = new CustomerDTO(response) });
            }
            else return TypedResults.BadRequest(new Payload<string> { Status = "Failure", Data = "Could not update" });
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomerById(IRepository<Customer> repository, int id)
        {
            var response = await repository.GetById(id);
            if (response != null)
            {
                return TypedResults.Ok(new CustomerDTO(response));
            } return TypedResults.NotFound("Customer does not exist");

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomerById(IRepository<Customer> repository, int id)
        {
            var response = await repository.DeleteById(id);
            if (response != null)
            {
                return TypedResults.Ok(new Payload<CustomerDTO> { Data = new CustomerDTO(response) });
            } return TypedResults.NotFound(new Payload<string> { Status = "Failure", Data = "Customer not found" });
        }

    }
}
