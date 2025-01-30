using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var movieGroup = app.MapGroup("/customers");

            movieGroup.MapGet("/", GetCustomers);
            movieGroup.MapPost("/", AddCustomer);
            movieGroup.MapPut("/{id}", UpdateCustomer);
            movieGroup.MapDelete("/{id}", DeleteCustomer);
        }

        public static async Task<IResult> GetCustomers(IRepository<Customer> repo, IMapper mapper)
        {
            var movies = await repo.Get();

            return Results.Ok(mapper.Map<List<Customer>>(movies));

        }

        public static async Task<IResult> AddCustomer(IRepository<Customer> repo, CustomerPost customer, IMapper mapper)
        {
            Customer newCustomer = new Customer
            {
                Name = customer.Name,
                Email = customer.Email,
                Phone = customer.Phone,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            var result = await repo.Add(newCustomer);
            return Results.Ok(mapper.Map<CustomerDTO>(result));
        }

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repo, int id, CustomerPost customer, IMapper mapper)
        {
            var existingCustomer = await repo.GetById(id);
            if (existingCustomer == null)
            {
                return Results.NotFound();
            }
            existingCustomer.Name = customer.Name;
            existingCustomer.Email = customer.Email;
            existingCustomer.Phone = customer.Phone;
            existingCustomer.UpdatedAt = DateTime.Now;
            var result = await repo.Update(existingCustomer);
            return Results.Ok(mapper.Map<Customer>(result));
        }

        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            var existingCustomer = await repo.GetById(id);
            if (existingCustomer == null)
            {
                return Results.NotFound();
            }
            var result = await repo.Delete(id);
            return Results.Ok(result);
        }

    }
}

