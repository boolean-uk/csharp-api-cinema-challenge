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
        private static async Task<IResult> CreateACustomer(Customer customer, ICustomerRepo service)
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
                    //service.Save();
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



            /*try
            {
                if (service.AddCustomer(customer)) return Results.Ok();
                return Results.NotFound();

            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }*/
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
        private static async Task<IResult> UpdateCustomer(Customer customer, ICustomerRepo service)
        {
            try
            {
                // need check from Nigel here
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
                    service.UpdateCustomer(customer);
                    //service.Save();
                    Payload<Customer> payload = new Payload<Customer>()
                    {
                        data = newCustomer
                    };

                    return Results.Created($"https://localhost:7195/customer/{newCustomer.Id}", payload);


                    //this was the code without the payload and success string added.It worked as it should
                    /*if (service.UpdateCustomer(customer)) return Results.Ok();
                    return Results.NotFound();*/
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
            //same as above need check from Nigel

            //added the using to get the target with id
            using (var db = new CinemaContext())
                try
                {
                    var target = db.Customers.FirstOrDefault(c => c.Id == id);
                    if (target == null) return Results.NotFound();
                    Customer newCustomer = new Customer();
                    newCustomer.Id = target.Id;
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

                    // Maybe this Service.Save that I dont have in the repository is responsible for not deleting the object
                    //service.Save();
                    

                    


                    //same as above this is previous code before adding payload and success string
                    /*if (service.DeleteCustomer(id)) return Results.Ok();
                    return Results.NotFound();*/

                }
                catch (Exception ex)
                {
                    return Results.Problem(ex.Message);
                }
        }
    }
}
