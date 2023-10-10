using api_cinema_challenge.Models.Customer;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication application)
        {
            application.MapGet("/customers", GetCustomers);
            application.MapPost("/customers", AddCustomer);
            application.MapPut("/customers/{id}", UpdateCustomer);
            application.MapDelete("/customers/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            try
            {
                var customers = repository.GetCustomers();
                return customers != null ? Results.Ok(customers) : Results.Problem();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }

        }
        

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddCustomer(CustomerPost customerPost, IRepository repository)
        {
            try
            {
                Customer customer = new Customer();
                customer.Name = customerPost.Name;
                customer.Email = customerPost.Email;
                customer.Phone = customerPost.Phone;
                customer.CreatedAt = DateTime.UtcNow;
                customer.UpdatedAt = DateTime.UtcNow;
                CustomerCreate customerCreate = new CustomerCreate();
                customerCreate.data = customer;

                if (repository.AddCustomer(customer)) return Results.Created("https://localhost:7195/customers", customerCreate);
                return Results.NotFound();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> UpdateCustomer(int id, CustomerPut customerPut, IRepository repository)
        {
          
            try
            {
                var targetCustomer = repository.GetCustomer(id);
                targetCustomer.Name = customerPut.Name;
                targetCustomer.Email = customerPut.Email;
                targetCustomer.Phone = customerPut.Phone;
                targetCustomer.UpdatedAt = DateTime.UtcNow;
                /* Customer updatedCustomer = new Customer();
                 updatedCustomer.Name = customerPut.Name;
                 updatedCustomer.Email = customerPut.Email;
                 updatedCustomer.Phone = customerPut.Phone;
                 updatedCustomer.UpdatedAt = DateTime.UtcNow;*/

                if (repository.UpdateCustomer(id, targetCustomer)) return Results.Created("https://localhost:7195/customers", targetCustomer);
                return Results.NotFound();
                

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        private static async Task<IResult> DeleteCustomer(int id, IRepository repository)
        {
            try
            {
                if (repository.DeleteCustomer(id)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

       





    }
}
