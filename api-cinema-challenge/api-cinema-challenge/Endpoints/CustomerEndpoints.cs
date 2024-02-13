using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models;
using api_cinema_challenge.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.IO.Pipes;
using System.Globalization;
using System.Net.Sockets;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using api_cinema_challenge.Utils;

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
        [Authorize(Roles = "Manager")]
        public static async Task<IResult> GetCustomers(ICustomerRepository repository)
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
        [Authorize()]
        public static async Task<IResult> CreateCustomer(CreateCustomerPayload payload, ICustomerRepository repository, ClaimsPrincipal user)
        {


            var uid = user.UserId();
            var email = user.UserEmail();

            if (uid == null)
            {
                return Results.Unauthorized();
            }

            if (payload.Name == "" || payload.Phone == "" || payload.Email == "")
            {
                return Results.BadRequest("Non-empty fields are required.");
            }

            if (payload.Name == null || payload.Phone == null || payload.Email == null)
            {
                return Results.BadRequest("Non-null fields are required.");
            }

            if (ValidationHelpers.IsValidEmail(payload.Email) == false)
            {
                return Results.BadRequest("Email needs to be in correct format.");
            }

            Customer? customer = await repository.CreateCustomer(payload.Name, payload.Email, payload.Phone, email);
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
        [Authorize()]
        public static async Task<IResult> DeleteCustomer(int id, ICustomerRepository repository, ClaimsPrincipal user)
        {

            var uid = user.UserId();
            var email = user.UserEmail();
            var pos = user.UserRole();

            if (uid == null)
            {
                return Results.Unauthorized();
            }



            Customer? customer = await repository.DeleteCustomer(id, PreloadPolicy.PreloadRelations);

            // customer can only delete themselves
            if (customer.Email != email && pos == "Customer")
            {
                return Results.Unauthorized();
            }

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
        [Authorize()]
        public static async Task<IResult> UpdateCustomer(int id, UpdateCustomerPayload payload, ICustomerRepository repository)
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
            string newEmail = (payload.email != null && payload.email.Length > 0 && ValidationHelpers.IsValidEmail(payload.email)) ? payload.email : ogcust.Email;

            // Email was changed, but the format was wrong
            if (payload.email != "" && ValidationHelpers.IsValidEmail(payload.email) == false)
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
