namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningEndpoint
    {
        public static void configureScreeningEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("screening");

        }
    }
}
