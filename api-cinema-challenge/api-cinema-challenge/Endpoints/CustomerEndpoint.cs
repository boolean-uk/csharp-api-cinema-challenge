using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoint
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("customers");
            group.MapGet("/", GetAll);
        }

        public static async Task<IResult> GetAll(IRepository<Customer> customerRepository)
        {
            throw new NotImplementedException();
        }
    }
}
