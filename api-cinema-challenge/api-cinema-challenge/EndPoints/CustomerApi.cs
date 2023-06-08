using api_cinema_challenge.Repository;
using System.Linq.Expressions;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", InsertCustomer);
            app.MapPut("/customers", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);
        }

        private static async Task<IResult> GetCustomers(ICinemaRepository repo)
        {
            try
            {
                var customers = repo.GetCustomers();
                return customers != null ? Results.Ok(customers) : Results.NoContent();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> InsertCustomer(Customer customer, ICinemaRepository repo)
        {
            try
            {
                var addedCustomer = repo.AddCustomer(customer);
                return addedCustomer != null ? Results.Created("https://localhost:7195/customers", addedCustomer) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> UpdateCustomer(Customer customer, ICinemaRepository repo)
        {
            try
            {
                var UpdatedCustomer = repo.AddCustomer(customer);
                return UpdatedCustomer != null ? Results.Ok(UpdatedCustomer) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> DeleteCustomer(int id, ICinemaRepository repo)
        {
            try
            {
                var DeletedCustomer = repo.DeleteCustomer(id);
                return DeletedCustomer != null ? Results.Ok(DeletedCustomer) : Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }



    }
}
