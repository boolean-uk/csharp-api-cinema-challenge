using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DataClasses;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.NewFolder;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPost("/", PostCustomer);
            customerGroup.MapPut("/{id}", PutCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
            customerGroup.MapGet("/{customerID}/screening/{screeningId}", GetTickets);
            customerGroup.MapPost("/{customerID}/screening/{screeningId}", PostTicket);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();

            var customers = await repository.GetCustomers();
            foreach (var customer in customers)
            {
                customerDTOs.Add(CreateCustomerDTO(customer));
            }
            payload.data = customerDTOs;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PostCustomer(ICustomerRepository repository, CustomerInputDTO input)
        {
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = CreateCustomerDTO( await repository.CreateCustomer(input));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PutCustomer(ICustomerRepository repository, CustomerInputDTO input, int id)
        {
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = CreateCustomerDTO(await repository.UpdateCustomer(input,id));
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = CreateCustomerDTO(await repository.DeleteCustomer(id));
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(ICustomerRepository repository, int customerid, int screeningid)
        {
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>();
            List<TicketDTO> ticketDTOs = new List<TicketDTO>();

            var tickets = await repository.GetTicket(customerid,screeningid);
            foreach (var ticket in tickets)
            {
                ticketDTOs.Add(CreateTicketDTO(ticket));
            }
            payload.data = ticketDTOs;
            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> PostTicket(ICustomerRepository repository, int customerid,int screeningid, TicketInputDTO input)
        {
            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            payload.data = CreateTicketDTO(await repository.CreateTicket(customerid,screeningid,input));
            return TypedResults.Ok(payload);
        }


        public static CustomerDTO CreateCustomerDTO (Customer customer)
        {
            return new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };
        }
        public static TicketDTO CreateTicketDTO(Ticket ticket)
        {
            return new TicketDTO
            {
                Id = ticket.Id,
                NumSeats = ticket.NumSeats,
                CreatedAt = ticket.CreatedAt,
                UpdatedAt = ticket.UpdatedAt
            };
        }
    }
}
