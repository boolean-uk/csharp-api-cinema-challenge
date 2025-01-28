using api_cinema_challenge.DTO;
using api_cinema_challenge.Exceptions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using AutoMapper;
using FluentValidation;
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
            group.MapPost("/", CreateCustomer);
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

                if (!customers.Any()) return TypedResults.NotFound();

                return TypedResults.Ok(mapper.Map<IEnumerable<CustomerDTO>>(customers));
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

                if (customer == null) return TypedResults.NotFound($"No customer with id:{id} was found.");

                return TypedResults.Ok(mapper.Map<CustomerDTO>(customer));
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
                    return Results.BadRequest(validationResult.Errors);
                }

                Customer customer = await repository.Get(c => c.Id == id);
                if (customer == null) return TypedResults.NotFound($"No customer with id:{id} was found.");

                customer.Name = entity.Name;
                customer.Email = entity.Email;
                customer.Phone = entity.Phone;
                customer.UpdatedAt = DateTime.UtcNow;

                await repository.Update(customer);

                return TypedResults.Ok(mapper.Map<CustomerDTO>(customer));
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
                    return Results.BadRequest(validationResult.Errors);
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

                return TypedResults.Created($"https://localhost:7235/customers/", mapper.Map<CustomerDTO>(customer));
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
                if (customer == null) return TypedResults.NotFound($"No customer with id:{id} was found.");

                await repository.Delete(customer);

                return TypedResults.Ok(mapper.Map<CustomerDTO>(customer));
            }
            catch (Exception ex)
            {
                return TypedResults.InternalServerError(mapper.Map<ErrorResponse>(ex));
            }

        }

    }
}
