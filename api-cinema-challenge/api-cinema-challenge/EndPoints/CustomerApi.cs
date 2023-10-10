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
        private static async Task<IResult> CreateCustomer(CustomerPost c, ICustomerRepository service)
        {
            throw new NotImplementedException();
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
        private static async Task<IResult> UpdateCustomer(int id, CustomerPut c, ICustomerRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Update a customer</summary>
        /// <returns>
        /// Status 200 - Customer object deleted
        /// </returns>
        private static async Task<IResult> DeleteCustomer(int id, ICustomerRepository service)
        {
            throw new NotImplementedException();
        }
    }
}
