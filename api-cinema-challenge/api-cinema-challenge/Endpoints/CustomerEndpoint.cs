
using Microsoft.AspNetCore.DataProtection.Repositories;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapPost("/CreateCustomer", CreateCustomer);
            customerGroup.MapGet("/GetAllCustomers", GetCustomers);
            customerGroup.MapPut("/UpdateCustomer/{id}", UpdateCustomerById);
            customerGroup.MapDelete("DeleteCustomer/{id}", DeleteCustomerById);
        }

        public static async Task<IResult> DeleteCustomerById()
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> UpdateCustomerById(HttpContext context)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> GetCustomers(HttpContext context)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> CreateCustomer(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
