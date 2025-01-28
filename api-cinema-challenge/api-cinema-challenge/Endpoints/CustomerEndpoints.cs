using api_cinema_challenge.Models;
using workshop.wwwapi.Repository;
using api_cinema_challenge.DTO;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void Configure( this WebApplication app)
        {
            var customers = app.MapGroup("/customers");
            customers.MapPost("/", CreateCustomer);
            customers.MapGet("/", GetCustomers);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
            customers.MapPost("/{customer_id}/screenings/{screening_id}", CreateTicket);
            customers.MapGet("/{customer_id}/screenings/{screening_id}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult>CreateCustomer(IRepository<Customer>repo, string name, string email, string phone)
        {
            IEnumerable<Customer> customers = await repo.Get();
            Customer customer = new Customer()
            {
                Name = name,
                Email = email,
                Phone = phone,
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            };

            await repo.Insert(customer);
            await repo.Save();

            CustomerDTO dto = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();

            payload.status = "success";
            payload.data.Add(dto);

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repo)
        {
            IEnumerable<Customer> customers = await repo.Get();
            
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            foreach (Customer customer in customers)
            {
                CustomerDTO customerdto = new CustomerDTO()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    createdAt = customer.createdAt,
                    updatedAt = customer.updatedAt
                };
               payload.data.Add(customerdto);
            }

            

            payload.status = "success";
            
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repo, int id, string name, string email, string phone)
        {
            Customer customer = await repo.GetById(id);
            customer.Name = name;
            customer.Email = email;
            customer.Phone = phone;
            customer.updatedAt = DateTime.UtcNow;
            await repo.Update(customer);
            await repo.Save();

            CustomerDTO dto = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();

            payload.status = "success";
            payload.data.Add(dto);

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            Customer customer = await repo.GetById(id);
            CustomerDTO dto = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                createdAt = customer.createdAt,
                updatedAt = customer.updatedAt
            };

            await repo.Delete(customer.Id);
            await repo.Save();

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();

            payload.status = "success";
            payload.data.Add(dto);


            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult>CreateTicket(IRepository<Ticket>TicketRepo, IRepository<Customer>CustomerRepo, IRepository<Screening> ScreeningRepo, int customerId, int screeningId, int numSeats)
        {
            Payload<TicketDTO>payload = new Payload<TicketDTO>();

            payload.status = "success";

            Customer customer = await CustomerRepo.GetById(customerId);
            Screening screening = await ScreeningRepo.GetById(screeningId);

            Ticket ticket = new Ticket
            {
                customer = customer,
                numSeats = numSeats,
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
                screening = screening
                
            };

            await TicketRepo.Insert(ticket);
            await TicketRepo.Save();

            
            TicketDTO dto = new TicketDTO()
            {
                id = ticket.customer.Id,
                numSeats = ticket.numSeats,
                createdAt = ticket.createdAt,
                updatedAt = ticket.updatedAt
            };

            payload.data.Add(dto);

            return TypedResults.Ok(payload);


        }

        public static async Task<IResult>GetTickets(IRepository<Ticket> TicketRepo, IRepository<Customer> CustomerRepo, IRepository<Screening> ScreeningRepo,int customerId, int screeningId)
        {
            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            payload.status = "success";
            var tickets = await TicketRepo.Get();
            Customer customer = await CustomerRepo.GetById(customerId);
            Screening screening = await ScreeningRepo.GetById(screeningId);

            foreach (Ticket ticket in tickets)
            {
                if (ticket.screening == screening && ticket.customer == customer)
                {
                    
                    TicketDTO dto = new TicketDTO()
                    {
                        id = customer.Id,
                        numSeats = ticket.numSeats,
                        createdAt = ticket.createdAt,
                        updatedAt = ticket.updatedAt
                    };
                    payload.data.Add(dto);
                }
            }
            return TypedResults.Ok(payload);

        }

    }
}
