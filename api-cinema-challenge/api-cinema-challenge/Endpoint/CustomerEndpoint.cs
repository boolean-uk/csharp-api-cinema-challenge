using api_cinema_challenge.DTO;
using api_cinema_challenge.Model;
using api_cinema_challenge.Payloads;
using api_cinema_challenge.Repository;
using System.Diagnostics;

namespace api_cinema_challenge.Endpoint
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app) 
        {
            var customerGroup = app.MapGroup("customer");
            customerGroup.MapPost("/create", Create);
            customerGroup.MapGet("/get", Get);
            customerGroup.MapPut("/update", Update);
            customerGroup.MapDelete("/delete", Delete);
        }
        
        public static async Task<IResult> Create(IRepository<Customer> repository, CreateCustomer customerInfo) 
        {
            Customer customer = new Customer()
            {
                Name = customerInfo.name,
                Email = customerInfo.email,
                Phone = customerInfo.phone,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.UtcNow              
            };
            Customer addedCustomer = await repository.Add(customer);            
            return TypedResults.Ok(addedCustomer);
        }

        public static async Task<IResult> Get(IRepository<Customer> repository) 
        {
            List<Customer> customers = await repository.Get();
            return TypedResults.Ok(customers);
        }

        public static async Task<IResult> Update(IRepository<Customer> repository, int id, CreateCustomer customerUpdates) 
        {
            Customer customer = await repository.GetById(id);
            customer.Name = customerUpdates.name;
            customer.Email = customerUpdates.email;
            customer.Phone = customerUpdates.phone;
            customer.UpdatedAt = DateTime.UtcNow;
            
            Customer updatedCustomer = await repository.Update(customer);
            Payload<Customer> payload = new Payload<Customer>()
            {
                Data = customer,
                Status = "success"
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Delete(IRepository<Customer> repository, int id) 
        {
            var customers = await repository.Get();
            Customer? customer = customers.Find(x => x.Id == id);
            if (customer == null) { return TypedResults.NotFound($"Customer with id {id} could not be found");}
            Customer deletedCustomer = await repository.Delete(customer);
            Payload<Customer> payload = new Payload<Customer>()
            {
                Status = "success",
                Data = deletedCustomer
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Test(IRepository<Customer> repository, int id) 
        {
            var noe = repository.GetById(id);
            Debug.WriteLine("VIDEREEEEEE");
            return TypedResults.Ok(true);
        } 
    }
}
