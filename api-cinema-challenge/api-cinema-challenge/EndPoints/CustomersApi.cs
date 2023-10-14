using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Customer;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomersApi
    {
        public static void ConfigureCustomersApi(this WebApplication app)
        {
            app.MapPost("/customers", AddCustomer);
            app.MapGet("/customers", GetCustomers);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customers/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> AddCustomer(CustomerPost model, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (model == null) return Results.NotFound();

                    Customer addedCustomer = new Customer();
                    addedCustomer.Email = model.Email;
                    addedCustomer.Name = model.Name;
                    addedCustomer.Phone = model.Phone;
                    addedCustomer.CreatedAt = DateTime.UtcNow;
                    addedCustomer.UpdatedAt = DateTime.UtcNow;

                    service.AddCustomer(addedCustomer);

                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = addedCustomer
                    };

                    return Results.Created($"/customers/{addedCustomer.Id}", payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Customer>> payload = new Payload<IEnumerable<Customer>>()
                    {
                        data = service.GetAllCustomers()
                    };

                    return Results.Ok(payload);
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(int id, CustomerPost model, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (model == null) return Results.NotFound();

                    var customer = service.GetCustomer(id);
                    customer.Email = model.Email;
                    customer.Name = model.Name;
                    customer.Phone = model.Phone;
                    customer.UpdatedAt = DateTime.UtcNow;
                    customer.CreatedAt = DateTime.UtcNow;

                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = customer
                    };

                    if (service.UpdateCustomer(customer)) return Results.Created($"/customers/{customer.Id}", payload);
                    return Results.NotFound($"No Customer with ID {id} was found!");
                });

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(int id, ICinemaRepository service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    var customer = service.GetCustomer(id);

                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = customer
                    };

                    if (service.DeleteCustomer(id)) return Results.Ok(payload);
                    return Results.NotFound($"No Customer with ID {id} was found!");
                });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
