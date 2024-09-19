using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapGet("/customerswithscreening", GetCustomersWithScreenings);
            customers.MapGet("/customerwithoutscreening", GetCustomersWithOutScreenings);
            customers.MapPost("/customerscreate", CreateCustomer);
            customers.MapPut("/customersupdate", UpdateCustomer);
            customers.MapDelete("/customersdelete", DeleteCustomer);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomersWithScreenings(IRepository repository)
        {
            var customers = await repository.GetCustomersWithScreening();

            if (customers == null) { return TypedResults.NotFound(); }

            List<CustomerDTOwithscreening> response = new List<CustomerDTOwithscreening>();

            foreach (Customer customer in customers.Where(c => c.ScreeningId is not null))
            {
                CustomerDTOwithscreening customerdto = new CustomerDTOwithscreening();
                customerdto.Id = customer.Id;
                customerdto.Name = customer.Name;
                customerdto.Email = customer.Email;
                customerdto.Phone = customer.Phone;
                customerdto.createdAt = DateTime.Now;
                customerdto.updatedAt = DateTime.Now;

                ScreeningDTO screendto = new ScreeningDTO();
                screendto.Id = customer.screening.Id;
                screendto.ScreenNumber = customer.screening.ScreenNumber;
                screendto.Capacity = customer.screening.Capacity;
                screendto.StartsAt = customer.screening.StartsAt;
                screendto.updatedAt = customer.screening.updatedAt;
                customerdto.Screens = screendto;

                response.Add(customerdto);

            }

            return TypedResults.Ok(response);

        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomersWithOutScreenings(IRepository repository)
        {
            var customers = await repository.GetCustomersWithoutScreening();

            if (customers == null) { return TypedResults.NotFound(); }

            List<CustomerDTOwithoutscreening> response = new List<CustomerDTOwithoutscreening>();

            foreach (Customer customer in customers.Where(c => c.ScreeningId is null))
            {
                CustomerDTOwithoutscreening customerdto = new CustomerDTOwithoutscreening();
                customerdto.Id = customer.Id;
                customerdto.Name = customer.Name;
                customerdto.Email = customer.Email;
                customerdto.Phone = customer.Phone;
                customerdto.createdAt = customer.createdAt;
                customerdto.updatedAt = customer.updatedAt;

                response.Add(customerdto);
            }
            return TypedResults.Ok(response);

        }


        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel model)
        {
            try
            {
                var createdcustomer = await repository.CreateCustomer(new Customer()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                });

                if (createdcustomer == null) { return TypedResults.NotFound(); }

                CustomerDTOwithoutscreening customerdto = new CustomerDTOwithoutscreening()
                {
                    Id = createdcustomer.Id,
                    Name = createdcustomer.Name,
                    Email = createdcustomer.Email,
                    Phone = createdcustomer.Phone,
                    createdAt = createdcustomer.createdAt,
                    updatedAt = createdcustomer.updatedAt,

                };

                return TypedResults.Created("/", customerdto);

            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);

            }
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPutModel model)
        {
            try
            {
                var customertoupdate = await repository.GetCustomerById(id);

                if (customertoupdate == null) { return TypedResults.NotFound(); }

                customertoupdate.Name = model.Name;
                customertoupdate.Email = model.Email;
                customertoupdate.Phone = model.Phone;

                await repository.UpdateCustomer(customertoupdate);

                CustomerDTOwithoutscreening customerdto = new CustomerDTOwithoutscreening()
                {
                    Id = customertoupdate.Id,
                    Name = customertoupdate.Name,
                    Email = customertoupdate.Email,
                    Phone = customertoupdate.Phone,
                    createdAt = customertoupdate.createdAt,
                    updatedAt = customertoupdate.updatedAt,
                };

                return TypedResults.Ok(customerdto);
            }
            
            catch(Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
         }

        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            try
            {
                var customer = await repository.GetCustomerById(id);

                if (customer == null) { return TypedResults.NotFound(); }

                var deletedcustomer = await repository.DeleteCustomer(customer.Id);

                CustomerDTOwithoutscreening customerdto = new CustomerDTOwithoutscreening()
                {
                    Id = deletedcustomer.Id,
                    Name = deletedcustomer.Name,
                    Email = deletedcustomer.Email,
                    Phone = deletedcustomer.Phone,
                    createdAt = deletedcustomer.createdAt,
                    updatedAt = deletedcustomer.updatedAt,

                };
                return TypedResults.Ok(customerdto);

            }
            catch(Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }


    }
   
}
