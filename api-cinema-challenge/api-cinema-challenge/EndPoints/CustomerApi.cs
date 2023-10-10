using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapPost("/customers", CreateCustomer);
            app.MapGet("/customers", GetCustomers);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);
        }

        /// <summary>Create a customer</summary>
        /// <returns>
        /// Status 201 - Customer object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateCustomer(CustomerPost c, ICustomerRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Customer customer = service.CreateCustomer(c);
                    Payload<Customer> payload = new Payload<Customer>() { data = customer };
                    return Results.Created($"/customers/{customer.id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        /// <summary>Get all customers</summary>
        /// <returns>
        /// Status 200 - List of all customers
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(ICustomerRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Update a customer</summary>
        /// <returns>
        /// Status 201 - Customer object updated
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateCustomer(int id, CustomerPut c, ICustomerRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Update a customer</summary>
        /// <returns>
        /// Status 200 - Customer object deleted
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteCustomer(int id, ICustomerRepository service)
        {
            throw new NotImplementedException();
        }
    }
}
