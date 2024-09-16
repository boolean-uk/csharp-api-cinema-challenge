using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {

        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetCustomers);
            customerGroup.MapPost("/", AddCustomer);
            customerGroup.MapPatch("/{id}", UpdateCustomer);
            customerGroup.MapDelete("/{id}", RemoveCustomer);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository, IMapper mapper)
        {
            var customers = await repository.GetAllCustomers();
            var customerDtos = mapper.Map<IEnumerable<GetCustomerDTO>>(customers);
           
            var payload = new Payload<IEnumerable<GetCustomerDTO>>
            {
                Data = customerDtos
            };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddCustomer(ICustomerRepository repository, IMapper mapper, PostCustomerDTO customerDTO)
        {
            Customer customer = mapper.Map<Customer>(customerDTO);
            var createdCustomer = await repository.AddCustomer(customer);
            var getCustomerDTO = mapper.Map<GetCustomerDTO>(createdCustomer);
            var location = $"/customers/{createdCustomer.Id}";

            var payload = new Payload<GetCustomerDTO>
            {
                Data = getCustomerDTO
            };

            return TypedResults.Created(location, payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(ICustomerRepository repository, IMapper mapper, PatchCustomerDTO customerDTO, int id)
        {
            Customer customer = mapper.Map<Customer>(customerDTO);
            Customer updatedCustomer = null;
            try
            {
                updatedCustomer = await repository.UpdateCustomer(id, customer);
            }
            catch(Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
          
            var getCustomerDTO = mapper.Map<GetCustomerDTO>(updatedCustomer);
            var location = $"/customers/{updatedCustomer.Id}";

            var payload = new Payload<GetCustomerDTO>
            {
                Data = getCustomerDTO
            };

            return TypedResults.Created(location, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> RemoveCustomer(ICustomerRepository repository, IMapper mapper, int id)
        {
            Customer deletedCustomer = null;

            try
            {
                deletedCustomer = await repository.DeleteCustomer(id);
            }
            catch(Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
    
            var getCustomerDTO = mapper.Map<GetCustomerDTO>(deletedCustomer);

            var payload = new Payload<GetCustomerDTO>
            {
                Data = getCustomerDTO
            };

            return TypedResults.Ok(payload);
        }
    }
}
