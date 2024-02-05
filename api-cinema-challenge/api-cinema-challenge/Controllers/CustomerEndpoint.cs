﻿using api_cinema_challenge.Models;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("/{id}", AddCustomer);
            customers.MapGet("", GetAllCustomers);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddCustomer(ICustomerRespository repository, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest("Invalid input");
            }

            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
            };

            return TypedResults.Created($"/{newCustomer.Id}", await repository.AddCustomer(newCustomer));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(ICustomerRespository repository)
        {
            return TypedResults.Ok(await repository.GetAllCustomers());
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRespository repository, int id, CustomerPost customer)
        {
            if (customer == null)
            {
                return TypedResults.BadRequest("Invalid input");
            }

            var changedCustomer = await repository.UpdateCustomer(id, customer);
            if (changedCustomer == null)
            {
                return TypedResults.NotFound($"Customer with id {id} was not found");
            }

            return TypedResults.Created($"{changedCustomer.Id}", changedCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(ICustomerRespository repository, int id)
        {
            var deletedCustomer = await repository.DeleteCustomer(id);
            if (deletedCustomer == null)
            {
                return TypedResults.NotFound($"Customer with id {id} was not found");
            }

            return TypedResults.Ok(deletedCustomer);
        }
    }
}
