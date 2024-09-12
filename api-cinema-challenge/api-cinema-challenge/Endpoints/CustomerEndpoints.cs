using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("/", CreateCustomer);
            customers.MapGet("/", GetCustomers);
            customers.MapGet("/{id}", GetCustomerById);
            customers.MapPut("/{id}", UpdateCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, PostCustomerDTO model)
        {
            try
            {
                Payload<ResponseCustomerDTO> payload = new Payload<ResponseCustomerDTO>();
                var newCustomer = await repository.CreateCustomer(new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow });
                payload.data = Mapper.MapToDTO(newCustomer);
                return TypedResults.Created($"https://localhost:7054/customers/{payload.data.Id}", payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest("Invalid customer object");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            var results = await repository.GetCustomers();
            List<Customer> customers = results.ToList();
            if (customers.Count <= 0)
            {
                return TypedResults.NoContent();
            }

            Payload<List<ResponseCustomerDTO>> payload = new Payload<List<ResponseCustomerDTO>>();
            List<ResponseCustomerDTO> responseCustomers = new List<ResponseCustomerDTO>();

            foreach (Customer c in customers)
            {
                responseCustomers.Add(Mapper.MapToDTO(c));
            }

            payload.data = responseCustomers;

            return TypedResults.Ok(payload.data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomerById(ICustomerRepository repository, int id)
        {
            try
            {
                var result = await repository.GetCustomerById(id);
                if (result is null)
                {
                    return TypedResults.NotFound("Customer Not Found");
                }

                Payload<ResponseCustomerDTO> payload = new Payload<ResponseCustomerDTO>();
                payload.data = Mapper.MapToDTO(result);

                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, int id, PutCustomerDTO model)
        {
            try
            {
                var target = await repository.GetCustomerById(id);
                if (target is null)
                {
                    return TypedResults.NotFound("Customer Not Found");
                }

                var updatedTarget = await repository.UpdateCustomer(id, new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone, UpdatedAt = DateTime.UtcNow });

                Payload<ResponseCustomerDTO> payload = new Payload<ResponseCustomerDTO>();
                payload.data = Mapper.MapToDTO(updatedTarget);

                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(ICustomerRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteCustomer(id);

                Payload<ResponseCustomerDTO> payload = new Payload<ResponseCustomerDTO>();
                payload.data = Mapper.MapToDTO(target);
                return TypedResults.Ok(payload.data);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
