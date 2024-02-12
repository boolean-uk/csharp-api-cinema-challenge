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
            CustomerServerDto dto = new CustomerServerDto()
            {
                Id = addedCustomer.Id,
                Name = addedCustomer.Name,
                Email = addedCustomer.Email,
                Phone = addedCustomer.Phone,
                CreatedAt = addedCustomer.CreatedAt,
                UpdatedAt = addedCustomer.UpdatedAt
            };
            Payload<CustomerServerDto> payload = new Payload<CustomerServerDto>()
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Get(IRepository<Customer> repository) 
        {
            List<Customer> customers = await repository.Get();
            var dto = customers.Select(c => new CustomerServerDto()
            {
                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            });
            Payload<IEnumerable<CustomerServerDto>> payload = new Payload<IEnumerable<CustomerServerDto>>()
            {
                Status = "success",
                Data = dto
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Update(IRepository<Customer> repository, int id, CreateCustomer customerUpdates) 
        {
            Customer customer = await repository.GetById(id);
            customer.Name = customerUpdates.name;
            customer.Email = customerUpdates.email;
            customer.Phone = customerUpdates.phone;
            customer.UpdatedAt = DateTime.UtcNow;
            
            Customer updatedCustomer = await repository.Update(customer);
            CustomerServerDto dto = new CustomerServerDto()
            {
                Id = updatedCustomer.Id,
                Name = updatedCustomer.Name,
                Email = updatedCustomer.Email,
                Phone = updatedCustomer.Phone,
                CreatedAt = updatedCustomer.CreatedAt,
                UpdatedAt = updatedCustomer.UpdatedAt
            };
            Payload<CustomerServerDto> payload = new Payload<CustomerServerDto>()
            {
                Status = "success",
                Data = dto
            };            
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Delete(IRepository<Customer> repository, int id) 
        {
            var customers = await repository.Get();
            Customer? customer = customers.Find(x => x.Id == id);
            if (customer == null) { return TypedResults.NotFound($"Customer with id {id} could not be found");}
            Customer deletedCustomer = await repository.Delete(customer);
            CustomerServerDto dto = new CustomerServerDto()
            {
                Id = deletedCustomer.Id,
                Name = deletedCustomer.Name,
                Email = deletedCustomer.Email,
                Phone = deletedCustomer.Phone,
                CreatedAt = deletedCustomer.CreatedAt,
                UpdatedAt = deletedCustomer.UpdatedAt
            };
            Payload<CustomerServerDto> payload = new Payload<CustomerServerDto>()
            {
                Status = "success",
                Data = dto
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
