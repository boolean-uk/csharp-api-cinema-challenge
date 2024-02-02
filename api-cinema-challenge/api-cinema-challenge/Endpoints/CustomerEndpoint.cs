using api_cinema_challange.Models;
using api_cinema_challange.Repository;
using System.Text.RegularExpressions;

namespace api_cinema_challange.Endpoints
{
    public static class CustomerApi
    {
        public static void ConfigureCustomerApi(this WebApplication app)
        {
            app.MapPost("/Customers", CreateCustomer);
            app.MapGet("/Customers", GetAllCustomers);
            app.MapPut("/Customers", UpdateCustomer);
            app.MapDelete("/Customers", DeleteCustomer);
        }

        private static async Task<IResult> GetAllCustomers(ICustomerRepository CustomerRepository)
        {
            return TypedResults.Ok(CustomerResponseDTO.FromRepository(await CustomerRepository.GetAllCustomers()));
        }

        private static async Task<IResult> CreateCustomer(ICustomerRepository CustomerRepository, CustomerPostPayload payload, IScreeningRepository screeningRepository)
        {
            //lägg till alla if satser
            if (!IsValidEmail(payload.Email))
            {
                return TypedResults.BadRequest("email must be in email format");
            }
            Customer? Customer = await CustomerRepository.CreateACustomer(payload.Name, payload.Email, payload.Phone);

            return TypedResults.Ok(CustomerResponseDTO.FromRepository(Customer));
        }

        private static async Task<IResult> UpdateCustomer(ICustomerRepository CustomerRepository, CustomerUpdatePayload payload)
        {
            if (!IsValidEmail(payload.Email))
            {
                return TypedResults.BadRequest("email must be in email format");
            }
            //lägg till alla if satser
            Customer? Customer = await CustomerRepository.UpdateCustomer(payload.id, payload.Name, payload.Email, payload.Phone);
            if (Customer == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(CustomerResponseDTO.FromRepository(Customer));
        }

        private static async Task<IResult> DeleteCustomer(ICustomerRepository CustomerRepository, int Customerid)
        {
            Customer? Customer = await CustomerRepository.DeleteCustomer(Customerid);
            if (Customer == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(CustomerResponseDTO.FromRepository(Customer));
        }

        private static bool IsValidEmail(string email)
        {
            // Define a regular expression for a simple email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }
    }
}
