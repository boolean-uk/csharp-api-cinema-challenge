using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapPost("/customers", CreateACustomer);
            app.MapGet("/customers", GetAllCustomers);
            app.MapPut("/customers", UpdateCustomer);
            app.MapDelete("/customers", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateACustomer(Customer customer, ICustomerRepo service)
        {
            try
            {
                if (service.AddCustomer(customer)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllCustomers(ICustomerRepo service)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(service.GetAllCustomers());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateCustomer(Customer customer, ICustomerRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (service.UpdateCustomer(customer)) return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteCustomer(int id, ICustomerRepo service)
        {
            try
            {
                if (service.DeleteCustomer(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
