using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.DTO;

namespace workshop.wwwapi.Endpoints
{

    public class CustomerPayload
    {
        public string? name { get; set; } public string? email { get; set; }
        public string? phone { get; set; }

        public bool AllFieldsFilled()
        {
            if (string.IsNullOrEmpty(name)) { return false; }
            if (string.IsNullOrEmpty(email)) { return false; }
            if (string.IsNullOrEmpty(phone)) { return false; }

            return true;
        }

        public bool IsValidEmail()
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

    }
    public static class CustomerEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");

            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPost("/", CreateACustomer);
            customerGroup.MapPut("/{id}", UpdateCustomerById);
            customerGroup.MapDelete("/{id}", DeleteCustomerById);

            /*customerGroup.MapGet("/patients/{id}", GetPatientsById);
            
            customerGroup.MapGet("/doctors", GetDoctors);
            customerGroup.MapGet("/appointmentsbydoctor/{id}", GetAppointmentsByDoctor);*/
        }
        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAllCustomers(ICustomerRepository repository)
        {
            var cResponse = await repository.GetAll();
            List<Customer> customerResponse = cResponse.ToList();


            return TypedResults.Ok(RequestDTO.Success(CustomerDTO.FromListOfCustomers(customerResponse)));
        }


        public static async Task<IResult> CreateACustomer(CustomerPayload payload, ICustomerRepository repository)
        {
            if (!payload.AllFieldsFilled()) { return TypedResults.BadRequest("All fields required."); }
            if(!payload.IsValidEmail()) { return TypedResults.BadRequest("Not a valid email."); }

            DateTime now = DateTime.UtcNow;
            Customer newCustomer = new Customer()
            {
                Name = payload.name,
                Email = payload.email,
                Phone = payload.phone,
                CreatedAt = now,
                UpdatedAt = now
            };

            var customerResponse = await repository.CreateACustomer(newCustomer);
           
            return TypedResults.Ok(RequestDTO.Success(new CustomerDTO(customerResponse)));
        }

        public static async Task<IResult> UpdateCustomerById(int id, CustomerPayload payload, ICustomerRepository repository)
        {
            if (!payload.AllFieldsFilled()) { return TypedResults.BadRequest("All fields required."); }
            if (!payload.IsValidEmail()) { return TypedResults.BadRequest("Not a valid email."); }

            var customerResponse = await repository.UpdateACustomer(id, payload.name, payload.email, payload.phone);

            return TypedResults.Ok(RequestDTO.Success(customerResponse));
        }
        public static async Task<IResult> DeleteCustomerById(int id, ICustomerRepository repository)
        {
            Customer? customerResponse = await repository.DeleteACustomer(id);
            if (customerResponse == null) { TypedResults.NotFound(); }

            return TypedResults.Ok(RequestDTO.Success(customerResponse));
        }



    }
}
