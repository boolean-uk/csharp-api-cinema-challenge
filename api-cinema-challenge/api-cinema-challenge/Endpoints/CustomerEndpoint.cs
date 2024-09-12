using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("/Create", CreateCustomer);
            customers.MapGet("/GetAll", GetCustomers);
            customers.MapPut("/Update{id}", UpdateCustomer);
            customers.MapDelete("/Delete{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, InputCustomerDTO data)
        {
            try
            {
                //Create new customer
                Customer customer = new Customer()
                {
                    Name = data.Name,
                    Email = data.Email,
                    Phone = data.Phone,
                    CreatedAt = DateTime.UtcNow
                };
                customer.UpdatedAt = customer.CreatedAt;
                var result = await repository.AddCustomer(customer);

                //Response
                return TypedResults.Created($"http://localhost:/customers/{result.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            try
            {
                var result = await repository.GetCustomers();

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, InputCustomerDTO data, int id)
        {
            try
            {
                //Create new customer
                Customer customer = new Customer()
                {
                    Name = data.Name,
                    Email = data.Email,
                    Phone = data.Phone,
                    CreatedAt = DateTime.UtcNow
                };
                customer.UpdatedAt = customer.CreatedAt;
                var result = await repository.UpdateCustomer(id, customer);

                //Response
                return TypedResults.Created($"http://localhost:/customers/{result.id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            try
            {
                var result = await repository.RemoveCustomer(id);

                //Response
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
