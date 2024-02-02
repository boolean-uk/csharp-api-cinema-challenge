using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;
using System.Net.Sockets;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {

        public static void ConfigureCustomerEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapGet("/customers", GetCustomers);
            // cinemaGroup.MapGet("/customers/{id}", GetCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

        }


        /// CUSTOMERS
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(ICustomer repository)
        { 

            var customers = await repository.GetCustomers();

            List<Object> custDTO = new List<Object>();

            foreach (Customer customer in customers)
            {
                var cust = new CustomerDTO(customer);
                custDTO.Add(cust);
            }

            StatusListDto sto = new StatusListDto(custDTO);

            return TypedResults.Ok(sto);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, ICustomer repository)
        {

            if (payload.Name == "" || payload.Phone == "" || payload.Email == "")
            {
                return Results.BadRequest("Non-empty fields are required.");
            }

            if (payload.Name == null || payload.Phone == null || payload.Email == null)
            {
                return Results.BadRequest("Non-null fields are required.");
            }

            if (HelperFunctions.IsValidEmail(payload.Email) == false)
            {
                return Results.BadRequest("Email needs to be in correct format.");
            }

            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            CustomerDTO cust = new CustomerDTO(customer);

            return TypedResults.Created($"/customers{customer.Id}", new StatusSingleDto( cust ));
        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteCustomer(int id, ICustomer repository)
        {

            Customer? customer = await repository.DeleteCustomer(id, PreloadPolicy.PreloadRelations);

            if (customer == null)
            {
                return Results.NotFound("customer not found");
            }

            CustomerDTO customerDTO = new CustomerDTO(customer);
            StatusSingleDto sto = new StatusSingleDto( customerDTO );

            repository.SaveChanges();

            return TypedResults.Ok(sto);
        }



        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, ICustomer repository)
        {

            var ogcust = repository.GetCustomers().Result.FirstOrDefault(x => x.Id == id);

            if (ogcust == null)
            {
                return Results.BadRequest("The customer does not exist.");
            }

            if (payload.name == "" && payload.phone == "" && payload.email == "")
            {
                return Results.BadRequest("Non-empty fields are required");
            }

            string newName  = (payload.name != null && payload.name.Length > 0) ? payload.name : ogcust.Name;
            string newPhone = (payload.phone != null && payload.phone.Length > 0) ? payload.phone : ogcust.Phone;
            string newEmail = (payload.email != null && payload.email.Length > 0 && HelperFunctions.IsValidEmail(payload.email)) ? payload.email : ogcust.Email;

            // Email was changed, but the format was wrong
            if (payload.email != "" && HelperFunctions.IsValidEmail(payload.email) == false)
            {
                return Results.BadRequest("Email format was incorrect!");
            }

            Customer? customer = await repository.UpdateCustomer(id, newName, newEmail, newPhone);
            if (customer == null)
            {
                return Results.BadRequest("Failed to create customer.");
            }

            repository.SaveChanges();

            CustomerDTO cdto = new CustomerDTO(customer);
            StatusSingleDto sto = new StatusSingleDto( cdto );

            return TypedResults.Created($"/customers{customer.Id}", sto);
        }
       
    }
}
