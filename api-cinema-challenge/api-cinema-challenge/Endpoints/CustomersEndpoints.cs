using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomersEndpoints
    {
        public static void ConfigureCustomers(this WebApplication app)
        {
            var customers = app.MapGroup("/customers");

            customers.MapPost("/", Insert);
            customers.MapGet("/", GetAll);
            customers.MapPut("/{id}", Update);
            customers.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Insert(IRepository<Customer> repository, IMapper mapper, CustomerPostDTO customer)
        {
            try
            {
                Customer insert = new Customer()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone
                };

                await repository.Insert(insert);

                return TypedResults.Created($"https://localhost:7195/customers/{insert.Id}", insert);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Customer> repository, IMapper mapper)
        {
            try
            {
                var customers = await repository.Get();

                var response = mapper.Map<List<CustomerDTO>>(customers);

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Update(IRepository<Customer> repository, int id, CustomerPostDTO customer)
        {
            try
            {
                var target = await repository.GetById(id);

                if (target == null)
                    return Results.NotFound();
                if (customer.Name != null)
                    target.Name = customer.Name;
                if (customer.Email != null)
                    target.Email = customer.Email;
                if (customer.Phone != null)
                    target.Phone = customer.Phone;
                target.UpdatedAt = DateTime.UtcNow;

                await repository.Update(target);

                return TypedResults.Created($"https://localhost:7195/customers/{target.Id}", target);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Delete(IRepository<Customer> repository, int id)
        {
            try
            {
                var target = await repository.GetById(id);

                if (await repository.Delete(id) != null)
                    return TypedResults.Ok(target);
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
