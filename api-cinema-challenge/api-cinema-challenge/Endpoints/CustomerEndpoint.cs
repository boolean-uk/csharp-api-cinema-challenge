
using api_cinema_challenge.DTO;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("/Customers");

            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPut("/{id}", UpdateACustomer);
            customerGroup.MapDelete("/{id}", DeleteACustomer);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteACustomer(ICustomer<Customer> repository, int id)
        {
            var entity = await repository.DeleteEntity(id);

            if (entity == null)
            {
                return TypedResults.NotFound();
            }

            var returnDto = Transfer.GetCustomer(entity);

            Payload<GetCustomerDTO> payload = new();
            if (entity != null)
            {
                payload.load = returnDto;
                payload.Status = "Success";
            }

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateCustomer(ICustomer<Customer> repository, PostCustomerDTO customerDTO)
        {

            Customer customer = Transfer.PostCustomer(customerDTO);

            var entity = await repository.CreateEntity(customer);
            Payload<Customer> payload = new();

            if (!(customerDTO == default(PostCustomerDTO)))
            {
                payload.load = customer;
                payload.Status = "Success";
            }
            else
            {
                payload.load = customer;
            }

            if ((payload.load.Name == null) || (payload.load.Email == null) || (payload.load.Phone == null))
                return TypedResults.BadRequest(" Some information is missing, Customer entry is not created");

            return TypedResults.Created("Success, saved in neonDB", payload);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        private static async Task<IResult> GetAllCustomers(ICustomer<Customer> repository)
        {
            CollectionResponse<GetCustomerDTO> response = new();
            Payload<List<GetCustomerDTO>> payload = new();

            var customerEntries = await repository.GetAllEntities();

            foreach (var customerEntry in customerEntries)
            {
                response.Load.Add(Transfer.GetCustomer(customerEntry));
            }
            payload.load = response.Load;
            payload.Status = "Success";

            if (response.Load.Count == 0)
                return TypedResults.NoContent();

            return TypedResults.Ok(payload);
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> UpdateACustomer(ICustomer<Customer> repository, PostCustomerDTO customerDTO, int id)
        {

            Customer customer = Transfer.UpdateCustomer(customerDTO);
            var entity = await repository.UpdateEntity(customer, id);

            if (entity == null)
            {
                return TypedResults.NotFound();
            }

            Payload<Customer> payload = new();

            if (!(customerDTO == default(PostCustomerDTO)))
            {
                payload.load = entity;
                payload.Status = "Success";
            }
            else
            {
                payload.load = entity;
            }

            return TypedResults.Created("Updated in neonDB", payload);
        }


    }
}
