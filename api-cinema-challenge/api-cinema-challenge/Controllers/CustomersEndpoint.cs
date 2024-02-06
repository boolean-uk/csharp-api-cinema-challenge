using api_cinema_challenge.Models.InputModels;
using api_cinema_challenge.Models.PureModels;
using api_cinema_challenge.Models.TransferModels;
using api_cinema_challenge.Models.TransferModels.Customer;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace api_cinema_challenge.Controllers
{
    public static class CustomersEndpoint
    {
        public static void ConfigureCustomersEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers/");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapGet("/{id}", GetCustomer);
            customerGroup.MapPost("/", PostCustomer);
            customerGroup.MapPut("/{id}", PutCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomers (IRepository<Customer> repo) 
        {
            IEnumerable<Customer> customers = await repo.GetAll();

            IEnumerable<CustomerDTO> customersOut = customers.Select(c => new CustomerDTO(c.CustomerId, c.CustomerName, c.Email, c.PhoneNumber, c.CreatedAt, c.UpdatedAt));
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>(customersOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetCustomer(IRepository<Customer> repo, int id)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null) 
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> PostCustomer(IRepository<Customer> repo, CustomerInputDTO customerPost)
        {

            Customer inputCustomer = new Customer()
            {
                CustomerName = customerPost.Name,
                Email = customerPost.Email,
                PhoneNumber = customerPost.Phone,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            Customer customer = await repo.Insert(inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutCustomer(IRepository<Customer> repo, int id, CustomerInputDTO customerPost)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            Customer inputCustomer = new Customer()
            {
                CustomerName = customerPost.Name ?? customer.CustomerName,
                Email = customerPost.Email ?? customer.Email,
                PhoneNumber = customerPost.Phone ?? customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = DateTime.Now
            };
            
            customer = await repo.Update(id, inputCustomer);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            Customer? customer = await repo.Get(id);

            if (customer == null)
            {
                return TypedResults.NotFound($"No customer with ID {id} found.");
            }

            customer = await repo.Delete(id);

            CustomerDTO customerOut = new CustomerDTO(customer.CustomerId, customer.CustomerName, customer.Email, customer.PhoneNumber, customer.CreatedAt, customer.UpdatedAt);
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>(customerOut);
            return TypedResults.Ok(payload);
        }
    }
}
