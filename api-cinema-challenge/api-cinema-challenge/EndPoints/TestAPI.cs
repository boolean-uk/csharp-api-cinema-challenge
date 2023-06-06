namespace api_cinema_challenge.EndPoints
{
    public static class TestAPI
    {
        public static void ConfigureTestAPI(this WebApplication app)
        {
            app.MapGet("/Test", GetTest);

        }

        private static async Task<IResult> GetTest()
        {
            string[] results = { "Apple", "Orange" };
            return Results.Ok(results);
        }
    }
}
