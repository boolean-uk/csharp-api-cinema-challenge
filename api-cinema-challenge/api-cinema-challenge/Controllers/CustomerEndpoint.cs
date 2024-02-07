using api_cinema_challenge.DTO;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customer");

            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetAllCustomer);
            customerGroup.MapPut("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);

        }


        public static async Task<IResult> CreateCustomer([FromBody] CustomerPayload payload, [FromServices] IRepository repository)
        {
            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            CustomerDto cust = new CustomerDto(customer);

            return TypedResults.Created($"/customers{customer.Id}", cust);
        }


        public static async Task<IResult> GetAllCustomer(IRepository repository)
        {
            var customers = await repository.GetAllCustomers();

            List<Object> custDTO = new List<Object>();

            foreach (Customer customer in customers)
            {
                var cust = new CustomerDto(customer);
                custDTO.Add(cust);
            }

            return TypedResults.Ok(custDTO);
   
        }



        public static async Task<IResult> UpdateCustomer([FromServices] IRepository repository, [FromRoute] int id, [FromBody] CustomerPayload customer)
        {
            var updatedCustomer = await repository.UpdateCustomer(id, customer.Name, customer.Email, customer.Phone);
            if (updatedCustomer == null)
            {
                return Results.NotFound($"Customer with id {id} not found.");
            }

            repository.SaveChanges();

            return Results.Ok(new CustomerDto(updatedCustomer));
        }




        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var deletedCustomer = await repository.DeleteCustomer(id);

            return TypedResults.Ok(deletedCustomer);
        }


    }
}
