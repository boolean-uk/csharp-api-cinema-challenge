using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomersApi
    {
        public static void ConfigureCustomersApi(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customers", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);
        }

        private static async Task <IResult>DeleteCustomer(int id, ICinemaRepository service)
        {
            try
            {
                if (service.DeleteCustomer(id)) return Results.Ok();
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem();
            }
        }

        private static async Task <IResult> UpdateCustomer(Customers customer, ICinemaRepository service)
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

        private static async Task<IResult> AddCustomer(Customers customer, ICinemaRepository service)
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

        private static async  Task <IResult> GetCustomers(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    return Results.Ok(service.GetCustomers());
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
    }
}
