

namespace api_cinema_challenge.Controllers
{
    public static class SilverScreenEndpoint
    {
        public static void ConfigureSilverScreenEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapPost("", CreateSilverScreen);
            customers.MapGet("", ReadAllSilverScreens);
            customers.MapPut("/{id}", ReadASilverScreen);
            customers.MapPut("/{id}", UpdateSilverScreen);
            customers.MapDelete("/{id}", DeleteSilverScreen);
        }

        private static Task CreateSilverScreen(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadAllSilverScreens(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task ReadASilverScreen(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task UpdateSilverScreen(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static Task DeleteSilverScreen(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
