using api_cinema_challenge.DTO;
using api_cinema_challenge.Enums;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Responses;
using api_cinema_challenge.ViewModels;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {

        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("customers");

            group.MapGet("/", GetCustomers);
            group.MapGet("/{id}", GetCustomerById);
            group.MapGet("/{id}/screenings/{screeningId}", GetScreeningTickets);
            group.MapPost("/", CreateCustomer);
            group.MapPost("/{id}/screenings/{screeningId}", CreateTicket);
            group.MapDelete("/{id}", DeleteCustomer);
            group.MapPut("/{id}", UpdateCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            try
            {
                IEnumerable<Customer> customers = await repository.GetAll();

                if (!customers.Any()) return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, "No customers found."));

                ApiResponse<IEnumerable<CustomerDTO>> response = new ApiResponse<IEnumerable<CustomerDTO>>(ApiStatus.Success, mapper.Map<IEnumerable<CustomerDTO>>(customers));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetScreeningTickets(IRepository<Ticket> repository, IMapper mapper, int customerId, int screeningId)
        {
            try
            {

                IEnumerable<Ticket> tickets = await repository.FindAll(t => t.CustomerId == customerId && t.ScreeningId == screeningId);
                if (!tickets.Any()) return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, "No tickets found."));

                ApiResponse<IEnumerable<TicketDTO>> response = new ApiResponse<IEnumerable<TicketDTO>>(ApiStatus.Success, mapper.Map<IEnumerable<TicketDTO>>(tickets));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> GetCustomerById(IRepository<Customer> repository, IMapper mapper, int id)
        {
            try
            {
                Customer customer = await repository.Get(c => c.Id == id);

                if (customer == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No customer with id:{id} was found."));
                }

                ApiResponse<CustomerDTO> response = new ApiResponse<CustomerDTO>(ApiStatus.Success, mapper.Map<CustomerDTO>(customer));

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, IMapper mapper, IValidator<UpdateCustomer> validator, int id, UpdateCustomer entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, validationResult.Errors));
                }

                Customer customer = await repository.Get(c => c.Id == id);
                if (customer == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No customer with id:{id} was found."));
                }

                customer.Name = entity.Name;
                customer.Email = entity.Email;
                customer.Phone = entity.Phone;
                customer.UpdatedAt = DateTime.UtcNow;

                await repository.Update(customer);

                ApiResponse<CustomerDTO> response = new ApiResponse<CustomerDTO>(ApiStatus.Success, mapper.Map<CustomerDTO>(customer));
                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, IMapper mapper, IValidator<CreateCustomer> validator, CreateCustomer entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, validationResult.Errors));
                }

                Customer newCustomer = new Customer
                {
                    Name = entity.Name,
                    Email = entity.Email,
                    Phone = entity.Phone,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                var customer = await repository.Add(newCustomer);

                ApiResponse<CustomerDTO> response = new ApiResponse<CustomerDTO>(ApiStatus.Success, mapper.Map<CustomerDTO>(customer));
                return TypedResults.Created($"https://localhost:7235/customers/{customer.Id}", response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, IMapper mapper, IValidator<CreateTicket> validator, int customerId, int screeningId, CreateTicket entity)
        {
            try
            {
                var validationResult = await validator.ValidateAsync(entity);

                if (!validationResult.IsValid)
                {
                    return Results.BadRequest(new ApiResponse<IEnumerable<ValidationFailure>>(ApiStatus.BadRequest, validationResult.Errors));
                }

                Customer customer = await customerRepository.Get(c => c.Id == customerId);
                if (customer == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No customer with id:{customerId} was found."));
                }

                Screening screening = await screeningRepository.Get(c => c.Id == screeningId);
                if (customer == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No customer with id:{screeningId} was found."));
                }

                Ticket newTicket = new Ticket
                {
                    NumSeats = entity.NumSeats,
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                Ticket ticket = await repository.Add(newTicket);

                ApiResponse<TicketDTO> response = new ApiResponse<TicketDTO>(ApiStatus.Success, mapper.Map<TicketDTO>(ticket));
                return TypedResults.Created($"https://localhost:7235/customers/{customerId}/screenings/{screeningId}", response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, IMapper mapper, int id)
        {
            try
            {
                Customer customer = await repository.Get(c => c.Id == id);

                if (customer == null)
                {
                    return TypedResults.NotFound(new ApiResponse<string>(ApiStatus.NotFound, $"No customer with id:{id} was found."));
                }

                await repository.Delete(customer);

                ApiResponse<CustomerDTO> response = new ApiResponse<CustomerDTO>(ApiStatus.Success, mapper.Map<CustomerDTO>(customer));
                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }
        }

    }
}
