using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.Payload;
using api_cinema_challenge.Models.Response;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        //private static CustomerService serv;
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            // serv = new CustomerService();

            var customer = app.MapGroup("/customers");
            customer.MapPost("/create", CreateCustomer);
            customer.MapGet("/get", GetCustomers);
            customer.MapPut("/update/{id}", UpdateCustomer);
            customer.MapDelete("/delete/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateCustomer(IRepository<Customer, CustomerPayload> repo, CustomerPayload payload)
        {
            Customer customer = await repo.Create(payload);

            CustomerDTO dto = new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt,
            };
            Response response = new Response("success", dto);
            return TypedResults.Created("/", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetCustomers(IRepository<Customer, CustomerPayload> repo)
        {
            IEnumerable<Customer> customers = await repo.GetAll();

            IEnumerable<CustomerDTO> cDTOS = customers.Select(c => new CustomerDTO()
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,
            });
            Response response = new Response("success", cDTOS);

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateCustomer(IRepository<Customer, CustomerPayload> repo, CustomerPayload payload, int id)
        {
            Customer customer = await repo.Update(payload, id);

            return customer != null
                ? TypedResults.Created("/", new Response("success", new CustomerDTO()
                    {
                        Id = customer.Id,
                        Name = customer.Name,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        CreatedAt = customer.CreatedAt,
                        UpdatedAt = customer.UpdatedAt,

                    }))
                : TypedResults.NotFound(new Response("failed", "Customer not found"));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository<Customer, CustomerPayload> repo, int id)
        {
            Customer customer = await repo.Delete(id);

            return customer != null
                ? TypedResults.Created("/", new Response("success", new CustomerDTO()
                    {
                        Id = customer.Id,
                        Name = customer.Name,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        CreatedAt = customer.CreatedAt,
                        UpdatedAt = customer.UpdatedAt,

                    }))
                : TypedResults.NotFound(new Response("failed", "Customer not found"));
        }



    }
}