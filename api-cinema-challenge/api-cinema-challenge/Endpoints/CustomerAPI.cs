using api_cinema_challenge.DOTs.CustomerDTOs;
using api_cinema_challenge.DOTs.TicketDTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;


namespace api_cinema_challenge.Endpoints
{
    public static class CustomerAPI
    {
        public static void ConfigueCustomer(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapGet("/customer{id}", GetCustomerById);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", BookTicket);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetAllTickets);
        }


        [Authorize(Roles ="Admin")]
        private static async Task<IResult> GetCustomers(IGenericRepository<Customer> repository)
        {
            var response = await repository.GetWithIncludes(q => q.Include(p => p.Tickets).ThenInclude(t => t.Screening).ThenInclude(s => s.Movie));
            var result = response.Select(c => new CustomerGetNoExtra(c));
            return TypedResults.Ok(result);
        }

        [Authorize(Roles = "User")]
        private static async Task<IResult> GetCustomerById(IGenericRepository<Customer> repository, int id)
        {
            var response = await repository.GetByIdWithIncludes(q => q.Where(i => i.Id == id)
                                                                        .Include(p => p.Tickets)
                                                                        .ThenInclude(t => t.Screening)
                                                                        .ThenInclude(s => s.Movie).FirstOrDefaultAsync().Result);
            var result = new CustomerGetNoExtra(response);

            return TypedResults.Ok(result);
        }

        [Authorize(Roles = "Admin")]
        private static async Task<IResult> CreateCustomer(IGenericRepository<Customer> repository, CustomerPost newCustomer)
        {
            Customer customer = new Customer(newCustomer);
            var response = await repository.Create(customer);
            CustomerGetNoExtra customerFormated = new CustomerGetNoExtra(response);
            return TypedResults.Created("", customerFormated);
        }
        [Authorize(Roles = "Admin")]
        private static async Task<IResult> UpdateCustomer(IGenericRepository<Customer> repository, int id, CustomerPut model)
        {
            Customer entity = await repository.GetByIdWithIncludes(q => q.Where(i => i.Id == id)
                                                                        .Include(p => p.Tickets)
                                                                        .ThenInclude(t => t.Screening)
                                                                        .ThenInclude(s => s.Movie).FirstOrDefaultAsync().Result);
            if (model.Name is not null) entity.Name = model.Name;
            if (model.Email is not null) entity.Email = model.Email;
            if (model.Phone is not null) entity.Phone = model.Phone;
            entity.UpdatedAt = DateTime.UtcNow;
            var response = await repository.Update(entity);
            return TypedResults.Created("", new CustomerGetNoExtra(response));
        }
        [Authorize(Roles = "Admin")]
        private static async Task<IResult> DeleteCustomer(IGenericRepository<Customer> repository, int id)
        {
            Customer entity = await repository.GetByIdWithIncludes(q => q.Where(i => i.Id == id).FirstOrDefaultAsync().Result);
            repository.Delete(entity);
            return TypedResults.Ok(entity);
        }


        [Authorize(Roles = "Admin")]
        private static async Task<IResult> BookTicket(IGenericRepository<Ticket> repository, TicketPost ticketPost, int screeningId, int customerId)
        {
            Ticket ticket = new Ticket(ticketPost, screeningId, customerId);
            var response = await repository.Create(ticket);
            return TypedResults.Created("Success", new TicketGet(response));
            
        }

        [Authorize(Roles = "User")]
        private static async Task<IResult> GetAllTickets(IGenericRepository<Ticket> repository, int customerId, int screeningId)
        {
            var response = await repository.GetWithIncludes(q => q.Where(c => c.CustomerId == customerId && c.ScreeningId == screeningId));
            return TypedResults.Ok(response.Select(c => new TicketGet(c)));
        }
    }
}
