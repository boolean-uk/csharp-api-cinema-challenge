using api_cinema_challange.Models;
using api_cinema_challange.Repository;

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

            Customer? Customer = await CustomerRepository.CreateACustomer(payload.title, payload.rating, payload.description, payload.runtimeMins);

            if (payload.screenings != null)
            {
                foreach (CustomerScreeningPostPayload screening in payload.screenings)
                {
                    await screeningRepository.CreateScreening(Customer.Id, screening.screen_number, screening.capacity, screening.startsAt);
                }
            }

            return TypedResults.Ok(CustomerResponseDTO.FromRepository(Customer));
        }

        private static async Task<IResult> UpdateCustomer(ICustomerRepository CustomerRepository, CustomerUpdatePayload payload)
        {
            //lägg till alla if satser
            Customer? Customer = await CustomerRepository.UpdateCustomer(payload.id, payload.title, payload.rating, payload.description, payload.runtimeMins);
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
    }
}
