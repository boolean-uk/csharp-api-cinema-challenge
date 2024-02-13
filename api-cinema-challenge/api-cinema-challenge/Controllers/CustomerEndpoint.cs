using api_cinema_challenge.Models.DatabaseModels;
using api_cinema_challenge.Models.Dto;
using api_cinema_challenge.Models.GenericDto;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.OpenApi.Any;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {

            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("", GetCustomers);
            customerGroup.MapPost("", CreateCustomer);
            customerGroup.MapPut("{id}", UpdateCustomer);
            customerGroup.MapDelete("{id}", DeleteCustomer);

            // Ticket
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", BookTicket);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetTickets);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            var entities = await repository.GetCustomers();

            List<CustomerDto> customers = new List<CustomerDto>();

            foreach (var entity in entities)
            {
                var customer = new CustomerDto()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt,
                    Screenings = entity.Screenings.Select(x => new ScreeningDto()
                    {
                        Id = x.Id,
                        ScreenNumber = x.ScreenNumber,
                        Capacity = x.Capacity,
                        StartsAt = x.StartsAt,
                        CreatedAt = x.CreatedAt,
                        UpdatedAt = x.UpdatedAt

                    }).ToList(),

                };
                customers.Add(customer);
            }

            PayLoad<List<CustomerDto>> result = new PayLoad<List<CustomerDto>>();
            result.data = customers;
            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, AddUpdateCustomerDto customer)
        {
            var customerEntities = await repository.GetCustomers();
            if (customerEntities.Any(c => c.Name == customer.Name)) 
            {
                return TypedResults.BadRequest("Customer with name already exists");
            }

            Customer entity = new Customer();

            entity.Name = customer.Name;
            entity.Email = customer.Email;
            entity.Phone = customer.Phone;
            await repository.CreateCustomer(entity);

            CustomerDto customerDto = new CustomerDto()
            {
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
            };

            PayLoad<CustomerDto> result = new PayLoad<CustomerDto>();
            result.data = customerDto;

            return TypedResults.Created(nameof(CreateCustomer), result);         
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int id, AddUpdateCustomerDto customer)
        {
            var entities = await repository.GetCustomers();
            var entity = await repository.GetCustomerById(id);

            if(!entities.Any(x => x.Id == id))
            {
                return TypedResults.NotFound("Customer was not found");
            }

            entity.Name = customer.Name;
            entity.Email = customer.Email;
            entity.Phone = customer.Phone;

            await repository.UpdateCustomer(entity, id);

            CustomerDto customerDto = new CustomerDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Screenings = entity.Screenings.Select(x => new ScreeningDto()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).ToList(),
            };

            PayLoad<CustomerDto> result = new PayLoad<CustomerDto>();
            result.data = customerDto;

            return TypedResults.Ok(result);
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            var entities = await repository.GetCustomers();
            if (!entities.Any(x => x.Id == id)) 
            {
                return TypedResults.NotFound("Customer not found");
            }

            var entity = await repository.GetCustomerById(id);
            await repository.DeleteCustomer(id);
            var customer = new CustomerDto()
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Phone = entity.Phone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                Screenings = entity.Screenings.Select(x => new ScreeningDto()
                {
                    Id = x.Id,
                    ScreenNumber = x.ScreenNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = x.CreatedAt,
                    UpdatedAt = x.UpdatedAt

                }).ToList(),
            };

            PayLoad<CustomerDto> result = new PayLoad<CustomerDto>();
            result.data = customer;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public async static Task<IResult> BookTicket(ICustomerRepository repository, BookTicketDto ticket, 
            [FromHeader(Name = "screenId")]int screenId,
            [FromHeader(Name = "customerId")]int customerId)
        {
            Ticket entity = new Ticket();
            entity.NumSeats = ticket.NumSeats;
            entity.ScreenId = screenId;
            entity.CustomerId = customerId;
            await repository.BookTicket(entity);

            var ticketDto = new TicketDto()
            {
                Id = entity.Id,
                NumSeats = entity.NumSeats,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                ScreeningId = entity.ScreenId,
                CustomerId = entity.CustomerId
            };

            PayLoad<TicketDto> result = new PayLoad<TicketDto>();
            result.data = ticketDto;

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public async static Task<IResult> GetTickets(ICustomerRepository repository, int customerId)
        {
            var entities = await repository.GetTickets();

            List<TicketDto> tickets = new List<TicketDto>();

            foreach(var entity in entities)
            {
                if(entity.Id == customerId)
                {
                    var ticket = new TicketDto()
                    {
                        Id = entity.Id,
                        NumSeats = entity.NumSeats,
                        CreatedAt = entity.CreatedAt,
                        UpdatedAt = entity.UpdatedAt,
                        CustomerId = entity.CustomerId,
                        ScreeningId = entity.ScreenId,
                    };
                    tickets.Add(ticket);
                }              
            }
            PayLoad<List<TicketDto>> result = new PayLoad<List<TicketDto>>();
            result.data = tickets;

            return TypedResults.Ok(result);
        }

    }
}
