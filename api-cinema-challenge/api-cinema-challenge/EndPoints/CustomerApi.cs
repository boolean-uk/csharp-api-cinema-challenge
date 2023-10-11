using api_cinema_challenge.Data;
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
        private static async Task<IResult> CreateACustomer(CustomerPost customer, ICustomerRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (customer == null) return Results.NotFound();
                    Customer newCustomer = new Customer();
                    newCustomer.email = customer.email;
                    newCustomer.name = customer.name;
                    newCustomer.phone = customer.phone;
                    newCustomer.createdAt = DateTime.UtcNow;
                    newCustomer.updatedAt = DateTime.UtcNow;
                    service.AddCustomer(newCustomer);
                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = newCustomer
                    };

                    return Results.Created($"https://localhost:7195/customer/{newCustomer.Id}", payload);
                });
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
                return await Task.Run(() =>
                {
                    Payload<IEnumerable<Customer>> payload = new Payload<IEnumerable<Customer>>()
                    {
                        data = service.GetAllCustomers().ToList()
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
        private static async Task<IResult> UpdateCustomer(CustomerPost customer, ICustomerRepo service)
        {
            try
            {
                return await Task.Run(() =>
                {
                    if (customer == null) return Results.NotFound();
                    Customer newCustomer = new Customer();
                    newCustomer.Id = customer.Id;
                    newCustomer.email = customer.email;
                    newCustomer.name = customer.name;
                    newCustomer.phone = customer.phone;
                    newCustomer.createdAt = DateTime.UtcNow;
                    newCustomer.updatedAt = DateTime.UtcNow;
                    service.UpdateCustomer(newCustomer);
                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = newCustomer
                    };

                    return Results.Created($"https://localhost:7195/customer/{newCustomer.Id}", payload);
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
            using (var db = new CinemaContext())
                try
                {
                    var target = db.Customers.FirstOrDefault(c => c.Id == id);
                    if (target == null) return Results.NotFound();
                    Customer newCustomer = new Customer();
                    //newCustomer.Id = target.Id;
                    newCustomer.email = target.email;
                    newCustomer.name = target.name;
                    newCustomer.phone = target.phone;
                    newCustomer.createdAt = DateTime.UtcNow;
                    newCustomer.updatedAt = DateTime.UtcNow;
                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = newCustomer
                    };
                    if (service.DeleteCustomer(id))
                    {
                        return Results.Created($"https://localhost:7195/customer/{newCustomer.Id}", payload);
                    }
                    else
                    {
                        return Results.NotFound();
                    }
                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
        }
    }
}
