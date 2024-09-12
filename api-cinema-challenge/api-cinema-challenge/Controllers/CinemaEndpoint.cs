using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_cinema_challenge.Controllers
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndPoints(this WebApplication app)
        {
            var Movie = app.MapGroup("movie");
            var Ticket = app.MapGroup("ticket");
            var Customer = app.MapGroup("customer");
            var Screen = app.MapGroup("screen");
            var Screening = app.MapGroup("screening");
            Customer.MapGet("/allcustomers", GetAllCustomers);
        } 

        public static async Task<IResult> GetAllCustomers(IRepository repository)
        {
            List<Customer> customers = await repository.GetAllCustomers();

            return TypedResults.Ok(customers);
        }
    }
}
