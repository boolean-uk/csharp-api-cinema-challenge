using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class CustomerEndpoint
    {
        // Base path of the api call, used for the created call...
        private static string _path = AppContext.BaseDirectory;
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customer = app.MapGroup("customers");
            customer.MapPost("/", CreateCustomer);
            customer.MapGet("/", GetCustomers);
            customer.MapPut("/{id}", UpdateCustomer);
            customer.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Customer() { Name = view.Name, Email = view.Email, Phone = view.Phone, CreatedAt = creationTime, UpdatedAt = creationTime };
            var result = await repository.Create([], model);
            var resultDTO = new CustomerDTO(result);

            var payload = new Payload<CustomerDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_path, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            var resultList = await repository.GetAll([]);
            var resultDTOs = new List<CustomerDTO>();
            foreach (var result in resultList)
            {
                resultDTOs.Add(new CustomerDTO(result));
            }

            var payload = new Payload<List<CustomerDTO>>() { Status = "success", Data = resultDTOs };
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerView view)
        {
            DateTime creationTime = DateTime.UtcNow;
            var model = new Customer() { Id = id, Name = view.Name, Email = view.Email, Phone = view.Phone, UpdatedAt = creationTime };
            var result = await repository.Update([], model);
            var resultDTO = new CustomerDTO(result);

            var payload = new Payload<CustomerDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Created(_path, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var result = await repository.Delete([], new Customer() { Id = id });
            var resultDTO = new CustomerDTO(result);

            var payload = new Payload<CustomerDTO>() { Status = "success", Data = resultDTO };
            return TypedResults.Ok(payload);
        }
    }
}
