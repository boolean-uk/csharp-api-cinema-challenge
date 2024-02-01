


namespace api_cinema_challenge.Endpoints {
    public static class ScreeningEndpoints {
        
        public static void ConfigureScreeningEndpoints(this WebApplication app) {
            var movies = app.MapGroup("/screening");

            movies.MapGet("/", GetScreenings);
            movies.MapGet("/{id}", GetScreening);
            movies.MapPut("/{id}", UpdateScreening);
            movies.MapPost("/", CreateScreening);
            movies.MapDelete("/{Id}", DeleteScreening);
        }

        private static async Task DeleteScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task CreateScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task UpdateScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task GetScreenings(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task GetScreening(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}