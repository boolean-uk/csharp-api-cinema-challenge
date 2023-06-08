using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerAPI
    {
        public static void ConfigureCustomerAPI(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapGet("/customers/{id}", GetCustomer);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customers", UpdateCustomer);
            app.MapDelete("/customers", DeleteCustomer);
        }

        private static async Task<IResult> GetCustomers(ICustomerRepository context)
        {
            try
            {
                return await Task.Run(() => {
                    return Results.Ok(context.GetCustomers());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetCustomer(int id, ICustomerRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var person = context.GetCustomer(id);
                    if (person == null) return Results.NotFound();
                    return Results.Ok(person);
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> AddCustomer(Customer customer, ICustomerRepository context)
        {
            try
            {
                if (context.AddCustomer(customer)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> UpdateCustomer(Customer customer, ICustomerRepository context)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (context.UpdateCustomer(customer)) return Results.Ok();
                    return Results.NotFound();
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteCustomer(int id, ICustomerRepository context)
        {
            try
            {
                if (context.DeleteCustomer(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
