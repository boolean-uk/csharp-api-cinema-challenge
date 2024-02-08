using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.Controllers
{
    public static class CustomerAPI
    {
        public static void ConfigureCustomerAPI(this WebApplication app)
        {
            var customerGroup = app.MapGroup("customers");
            customerGroup.MapGet("/", GetAllCustomers);
        }

        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var response = await repository.GetAll();
            return TypedResults.Ok(response.data);
        }


    }}
