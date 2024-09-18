using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("/customers");

            cinemaGroup.MapGet("/", GetCustomers);
            cinemaGroup.MapPost("/", CreateCustomer);
            cinemaGroup.MapPut("/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/{id}", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(ICustomerRepository repository, CustomerPOSTModel model)
        {
            var newCustomer = await repository.AddAsync(new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone });
            if (newCustomer != null)
            {
                CustomerDTO customer = new CustomerDTO() 
                {
                    Id = newCustomer.Id, 
                    Name = newCustomer.Name, 
                    Phone = newCustomer.Phone, 
                    Email = newCustomer.Email, 
                    CreatedAt = newCustomer.CreatedAt, 
                    UpdatedAt = newCustomer.UpdatedAt 
                };
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = customer;
                payload.status = "success";
                return TypedResults.Created(payload.status, payload);
            }
            else
            {
                return TypedResults.BadRequest("Could not create customer");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
        {
            var found = await repository.GetCustomers();
            if (found != null)
            {
                //CustomerResponseDTO response = new CustomerResponseDTO();
                Payload<List<CustomerDTO>> payload = new Payload<List<CustomerDTO>>();
                payload.data = new List<CustomerDTO>();

                foreach (var c in found)
                {
                    payload.data.Add(new CustomerDTO()
                    {
                        Id = c.Id,
                        Name = c.Name,
                        Phone = c.Phone,
                        Email = c.Email,
                        CreatedAt = c.CreatedAt,
                        UpdatedAt = c.UpdatedAt
                    });
                }
                payload.status = "success";
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound();
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer (ICustomerRepository repository, CustomerPUTModel model, int id)
        {
            var changedCustomer = await repository.GetCustomerById(id);
            if (changedCustomer != null)
            {
                CustomerPUTModel innModel = (new CustomerPUTModel() { Name = model.Name, Email = model.Email, Phone = model.Phone });
                if (innModel.Name != "")
                {
                    changedCustomer.Name = innModel.Name;
                }
                if (innModel.Email != "")
                {
                    changedCustomer.Email = innModel.Email;
                }
                if (innModel.Phone != "")
                {
                    changedCustomer.Phone = innModel.Phone;
                }
                await repository.UpdateAsync(changedCustomer);
                CustomerDTO customer = new CustomerDTO()
                {
                    Id = changedCustomer.Id,
                    Name = changedCustomer.Name,
                    Phone = changedCustomer.Phone,
                    Email = changedCustomer.Email,
                    CreatedAt = changedCustomer.CreatedAt,
                    UpdatedAt = changedCustomer.UpdatedAt
                };
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = customer;
                payload.status = "success";
                return TypedResults.Created(payload.status, payload);
            }
            else
            {
                return TypedResults.BadRequest("Could not update customer");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer (ICustomerRepository repository, int id)
        {
            var deletedCustomer = await repository.DeleteAsync(id);
            if (deletedCustomer != null)
            {
                CustomerDTO customer = new CustomerDTO()
                {
                    Id = deletedCustomer.Id,
                    Name = deletedCustomer.Name,
                    Phone = deletedCustomer.Phone,
                    Email = deletedCustomer.Email,
                    CreatedAt = deletedCustomer.CreatedAt,
                    UpdatedAt = deletedCustomer.UpdatedAt
                };
                Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
                payload.data = customer;
                payload.status = "success";
                return TypedResults.Ok(payload);
            }
            else
            {
                return TypedResults.NotFound("Could not delete customer, reason: No such customer");
            }
        }
    }
}
