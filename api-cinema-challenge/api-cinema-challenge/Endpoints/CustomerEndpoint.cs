using api_cinema_challenge.Models;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("/customers");
            customerGroup.MapGet("", GetCustomers);
            customerGroup.MapGet("/{id}", GetCustomerById);
        }

        private static async Task<IResult> GetCustomers(IRepository<Customer> repo)
        {
            var customers = await repo.Get();
            return Results.Ok(customers.Select(customer => new {
                customer.Id,
                customer.Name,
                customer.Email,
                customer.Phone,
                customer.CreatedAt,
                customer.UpdatedAt,
            }));
        }

        private static async Task<IResult> GetCustomerById(IRepository<Customer> repo, int id)
        {
            var customer = await repo.GetByIdAsync(id);
            if (customer == null) return Results.NotFound();

            return Results.Ok(new
            {
                customer.Id,
                customer.Name,
                customer.Email,
                customer.Phone,
                customer.CreatedAt,
                customer.UpdatedAt
            });
        }
    }
}
