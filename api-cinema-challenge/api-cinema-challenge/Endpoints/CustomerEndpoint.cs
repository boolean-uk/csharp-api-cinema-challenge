using api_cinema_challenge.Models.Base;
using api_cinema_challenge.Models.InputDTOs;
using api_cinema_challenge.Models.OutputDTOs;
using api_cinema_challenge.Repository.ExtensionRepository;
using api_cinema_challenge.Repository.GenericRepository;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            app.MapGet("/customers", GetCustomers);
            app.MapGet("/customers/{id}", GetCustomerById);
            app.MapPost("/customers", CreateCustomer);
            app.MapPut("/customers/{id}", UpdateCustomer);
            app.MapDelete("/customer/{id}", DeleteCustomer);
        }

        private static async Task<IResult> CreateCustomer(IRepository<Customer> repo, CustomerInputDto inputDto)
        {
            var customer = new Customer 
            { 
                Name = inputDto.Name,
                Email = inputDto.Email,
                Phone = inputDto.Phone,
                UpdatedAt = DateTime.UtcNow,
                CreatedAt = DateTime.UtcNow,
            };

            var inserted = await repo.Insert(customer);
            return TypedResults.Created($"/customers/{inserted.Id}", new Payload<object>().Get(CustomerOutputDto.Create(inserted)));
        }

        private static async Task<IResult> UpdateCustomer(IRepository<Customer> repo, int customerId, CustomerInputDto inputDto)
        {

            var customer = await repo.GetById(customerId);
            customer.Id = customerId;
            customer.Name = inputDto.Name;
            customer.Email = inputDto.Email;
            customer.Phone = inputDto.Phone;
            customer.UpdatedAt = DateTime.UtcNow;
            

            var updated = await repo.Update(customer);
            return TypedResults.Accepted($"/customers/{customerId}", new Payload<object>().Get(CustomerOutputDto.Create(updated)));
        }


        private static async Task<IResult> GetCustomers(IRepository<Customer> repo)
        {
            var customers = await repo.Get();
            return Results.Ok(new Payload<object>().Get(customers.Select(CustomerOutputDto.Create)));
        }

        private static async Task<IResult> GetCustomerById(IRepository<Customer> repo, int id)
        {
            var customer = await repo.GetById(id);
            if (customer == null) return Results.NotFound();
            return Results.Ok(new Payload<object>().Get(CustomerOutputDto.Create(customer)));
        }

        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
        {
            var customer = await repo.GetById(id);
            var customerDto = CustomerOutputDto.Create(customer);
            await repo.Delete(id);
            return Results.Ok(new Payload<object>().Get(customerDto));
        }
    }
}
