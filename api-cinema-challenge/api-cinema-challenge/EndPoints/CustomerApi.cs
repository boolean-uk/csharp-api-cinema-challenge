using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerAPI(this WebApplication app)
        {
            app.MapGet("/Customers", GetCustomers);
            app.MapPost("/Customers", AddCustomer);
            app.MapGet("/Customers/{id}", GetCustomer);
            app.MapDelete("/Customers/{id}", DeleteCustomer);
            app.MapPut("/Customers/{id}", UpdateCustomer);




        }


        private static async Task<IResult> GetCustomer(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.GetCustomerById(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Customer with id {id} not found");
             }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

        private static async Task<IResult> AddCustomer(ICinemaRepo repo, Customer customer)
        {
            try
            {
                return Results.Ok(repo.CreateCustomer(customer));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetCustomers(ICinemaRepo repo)
        {
            try
            {
                return Results.Ok(repo.GetAllCustomers());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteCustomer(ICinemaRepo repo, int id)
        {
            try
            {
                var result = repo.DeleteCustomer(id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Customer with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
        private static async Task<IResult> UpdateCustomer(ICinemaRepo repo, int id, Customer cust)
        {
            try
            {
                var result = repo.UpdateCustomer(cust,id);
                return result != null ? Results.Ok(result) : Results.NotFound($"Customer with id {id} not found");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }

    }
}
