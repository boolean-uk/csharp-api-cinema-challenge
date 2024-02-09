using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.PayLoad;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", PostCustomer);
            customers.MapGet("", GetAllCustomers);
            customers.MapGet("/{id}", GetACustomer);
            customers.MapPut("/{id}", PutCustomer);
            customers.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PostCustomer(IRepository<Customer> repository, CustomerPost model)
        {
            // Map the model to a DTO
            var customerDTO = DTOHelper.MapToDTO<CustomerDTO>(model);

            // Create a payload to return
            var payload = new PayLoad1<CustomerDTO>
            {
                data = customerDTO,
                status = DTOHelper.PropertyChecker<CustomerDTO>(customerDTO)
            };

            // Check if the DTO properties are valid
            if (payload.status == "success")
            {
                // Insert the new customer into the database
                var customer = await repository.Insert(DTOHelper.MapToEntity<Customer>(model, "create"));

                //Give the customerDTO the new customer's id
                payload.data = DTOHelper.MapToDTO<CustomerDTO>(customer);

                // Return the payload
                return TypedResults.Created($"/{payload.data.Id}", payload);
            }
            else
            {
                // Return the payload
                return TypedResults.BadRequest(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.SelectAll();
            IEnumerable<CustomerDTO> customerDTOs = customers.Select(c => DTOHelper.MapToDTO<CustomerDTO>(c));

            var payload = new PayLoad1<IEnumerable<CustomerDTO>>
            {
                data = customerDTOs,
                status = customerDTOs.Any() ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetACustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.SelectById(id);
            var customerDTO = DTOHelper.MapToDTO<CustomerDTO>(customer);

            var payload = new PayLoad1<CustomerDTO>
            {
                data = customerDTO,
                status = customerDTO != null ? "success" : "not found"
            };

            if (payload.status == "success")
            {
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound(payload);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> PutCustomer(IRepository<Customer> repository, int id, CustomerPut model)
        {
            var entity = DTOHelper.MapToEntity<Customer>(model, "update");

            var payload = new PayLoad1<CustomerDTO>
            {
                data = null,
                status = DTOHelper.PropertyChecker<CustomerDTO>(DTOHelper.MapToDTO<CustomerDTO>(model))
            };

            if (payload.status == "success")
            {
                // Update the existing customer with the modified entity
                var updatedCustomer = await repository.Update(id, entity);

                // Map updated entity back to DTO
                payload.data = DTOHelper.MapToDTO<CustomerDTO>(updatedCustomer);

                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.BadRequest(payload);
            }
        }

        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var foundCustomerClass = await repository.Delete(id);
            if (foundCustomerClass == null)
            {
                return TypedResults.NotFound("The customer does not exist");
            }
            var payload = new PayLoad1<CustomerDTO>
            {
                data = DTOHelper.MapToDTO<CustomerDTO>(foundCustomerClass),
                status = "success"
            };

            return TypedResults.Ok(payload);
        }
    }
}
