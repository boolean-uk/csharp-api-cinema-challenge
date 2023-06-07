using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using System.Linq.Expressions;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapPost("/customers", AddCustomer);
            app.MapPut("/customers", UpdateCustomer);
            app.MapDelete("/customers{id}", DeleteCustomer);
        }

        public static async Task<IResult> GetCustomers(ICinemaRepository repository)
        {
            try
            {
                var customers = repository.GetCustomers();
                return customers != null ? Results.Ok(customers) : Results.Problem("There are no customers yet");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> AddCustomer(Customer customer, ICinemaRepository repository)
        {
            try
            {
                var item = repository.AddCustomer(customer);
                return item != null ? Results.Created("https://localhost:7174/customers", item) : Results.Problem("There is no customer to be added");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> UpdateCustomer(Customer customer, ICinemaRepository repository)
        {
            try
            {
                var item = repository.UpdateCustomer(customer);
                return item != null ? Results.Ok(item) : Results.Problem($"There is no customer with id of {customer.Id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteCustomer(int id, ICinemaRepository repository)
        {
            try
            {
                var customer = repository.DeleteCustomer(id);
                return customer != null ? Results.Ok(customer) : Results.Problem($"There is no customer with id of {id}");
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
