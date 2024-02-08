

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", CreateScreening);
            customers.MapGet("", ReadAllScreenings);
            customers.MapPut("/{id}", ReadAScreening);
            customers.MapPut("/{id}", UpdateScreening);
            customers.MapDelete("/{id}", DeleteScreening);
        }

        private static Task CreateScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAllScreenings(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
