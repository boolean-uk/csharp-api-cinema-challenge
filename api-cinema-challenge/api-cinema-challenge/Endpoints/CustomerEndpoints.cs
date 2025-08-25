using api_cinema_challenge.DTOs.Customers;
using api_cinema_challenge.DTOs.Tickets;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customersGroup = app.MapGroup("customers");

            customersGroup.MapGet("/", GetCustomers);
            customersGroup.MapPost("/", AddCustomer);
            customersGroup.MapPut("/{id}", UpdateCustomer);
            customersGroup.MapDelete("/{id}", DeleteCustomer);

            customersGroup.MapGet("/{customer_id}/screening/{screening_id}", GetTickets);
            customersGroup.MapPost("/{customer_id}/screening/{screening_id}", AddTicket);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository, ClaimsPrincipal user)
        {
            var customers = await repository.Get();

            var response = new 
            {
                Status = "success",
                Data = customers.Select(customer => new CustomerDTO
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt
                }).ToList()
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> repository, CustomerPost model, ClaimsPrincipal user)
        {
            Customer entity = new Customer();
            entity.Name = model.Name;
            entity.Email = model.Email;
            entity.Phone = model.Phone;

            await repository.Insert(entity);

            var response = new
            {
                Status = "success",
                Data = new CustomerDTO
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/customers/{entity.Id}", response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerPut model, ClaimsPrincipal user)
        {
            var entity = await repository.GetById(id);

            if (model.Name != null) entity.Name = model.Name;
            if (model.Email != null) entity.Email = model.Email;
            if (model.Phone != null) entity.Phone = model.Phone;
            entity.UpdatedAt = DateTime.UtcNow;

            await repository.Update(entity);

            var updatedEntity = await repository.GetById(id);

            var response = new
            {
                Status = "success",
                Data = new CustomerDTO
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/customers/{entity.Id}", response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id, ClaimsPrincipal user)
        {
            var entity = await repository.GetById(id);

            await repository.Delete(id);

            var response = new
            {
                Status = "success",
                Data = new CustomerDTO
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int customer_id, int screening_id, ClaimsPrincipal user)
        {
            var tickets = await repository.Get();
            tickets = tickets.Where(t => t.CustomerId == customer_id && t.ScreeningId == screening_id);

            var response = new
            {
                Status = "success",
                Data = tickets.Select(ticket => new TicketDTO
                {
                    Id = ticket.Id,
                    numSeats = ticket.numSeats,
                    CreatedAt = ticket.CreatedAt,
                    UpdatedAt = ticket.UpdatedAt
                }).ToList()
            };

            return TypedResults.Ok(response);
        }

        [Authorize]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public static async Task<IResult> AddTicket(IRepository<Ticket> repository, TicketPost model, int customer_id, int screening_id, ClaimsPrincipal user)
        {
            Ticket entity = new Ticket();
            entity.CustomerId = customer_id;
            entity.ScreeningId = screening_id;
            entity.numSeats = model.numSeats;

            await repository.Insert(entity);

            var response = new
            {
                Status = "success",
                Data = new TicketDTO
                {
                    Id = entity.Id,
                    numSeats = entity.numSeats,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                }
            };

            return TypedResults.Created($"https://localhost:7239/customers/{entity.CustomerId}/screenings/{entity.ScreeningId}", response);
        }
    }
}
