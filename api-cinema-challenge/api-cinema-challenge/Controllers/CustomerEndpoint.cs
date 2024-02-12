using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {

        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer/");

            customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapGet("", GetAllCustomers);
            customerGroup.MapPut("{id}", UpdateCustomer);
            customerGroup.MapDelete("{id}", DeleteCustomer);
            customerGroup.MapPost("{customerId}/screenings/{screeningId}", CreateTicket);
            customerGroup.MapGet("{customerId}/screenings/{screeningId}", GetTickets);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> customerRepo, PostCustomer model)
        {
            var entity = new Customer() { Name = model.Name, Phone = model.Phone };
            var create = await customerRepo.Create(entity);

            var result = new CustomerDTO()
            {
                Id = create.Id,
                Name = create.Name,
                Phone = create.Phone,
                CreatedAt = create.CreatedAt,
                UpdatedAt = create.UpdatedAt,
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = result;

            return TypedResults.Created(payload.status, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepo)
        {
            var result = await customerRepo.GetAll();
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            var response = from customer in result
                           select new CustomerDTO()
                           {
                               Id = customer.Id,
                               Name = customer.Name,
                               Phone = customer.Phone,
                               CreatedAt = customer.CreatedAt,
                               UpdatedAt = customer.UpdatedAt,
                           };
            payload.data = response;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepo, int id, PutCustomer model)
        {
            var entity = await customerRepo.GetById(id);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            if (entity == null)
            {
                payload.data = null;
                payload.status = "Not found";
                return TypedResults.NotFound(payload.status);
            }
            entity.Name = model.Name;
            entity.Phone = model.Phone;
            var result = await customerRepo.Update(entity);
            var DTO = new CustomerDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Phone = result.Phone,
                CreatedAt = result.CreatedAt,
                UpdatedAt = result.UpdatedAt,
            };
            payload.data = DTO;

            return TypedResults.Created(payload.status, payload);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> customerRepo, int id)
        {
            var result = await customerRepo.Delete(id);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            if (result == null)
            {
                payload.status = "Not Found";
                payload.data = null;
                return TypedResults.NotFound(payload.status);
            }
            var DTO = new CustomerDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Phone = result.Phone,
                CreatedAt = result.CreatedAt,
                UpdatedAt = result.UpdatedAt,
            };

            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> ticketRepo,
                                                    IRepository<Customer> customerRepo,
                                                    IRepository<Screening> screeningRepo,
                                                    PostTicket model,
                                                    int customerId,
                                                    int screeningId)
        {
            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            if (screeningRepo.GetById(screeningId) == null)
            {
                payload.status = $"Screening with id {screeningId} does not exist";
                payload.data = null;
                return TypedResults.NotFound(payload);
            }

            var entity = new Ticket()
            {

                NumSeats = model.NumSeats,
                ScreeningId = screeningId,
                CustomerId = customerId,
            };
            var create = await ticketRepo.Create(entity);

            var result = new TicketDTO()
            {
                Id = create.Id,
                NumSeats = model.NumSeats,
                CreatedAt = create.CreatedAt,
                UpdatedAt = create.UpdatedAt,
            };
            payload.data = result;

            return TypedResults.Created(payload.status, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public static async Task<IResult> GetTickets(IRepository<Customer> customerRepo, 
                                                     IRepository<Screening> screeningRepo, 
                                                     int customerId,
                                                     int screeningId)
        {
            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>();

            var customer = await customerRepo.GetById(customerId);
            var screening = await screeningRepo.GetById(screeningId);
            if (customer == null)
            {
                payload.status = "Not Found";
                payload.data = null;
                return TypedResults.NotFound(payload);
            }

            var tickets = from ticket in customer.Tickets
                             join t in screening.Tickets on ticket.Id equals t.Id
                             select new TicketDTO()
                             {
                                 Id = ticket.Id,
                                 NumSeats = ticket.NumSeats,
                                 CreatedAt = ticket.CreatedAt,
                                 UpdatedAt = ticket.UpdatedAt,
                             };
            payload.data = tickets;
            return TypedResults.Ok(payload);

        }
    }
}
