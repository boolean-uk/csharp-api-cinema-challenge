
namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigurescreeningEndpoint(this WebApplication app)
        {
            var screeningGroup = app.MapGroup("screening");

            screeningGroup.MapPost("/CreateScreening/{id}", CreateScreeningByMovieId);
            screeningGroup.MapGet("/GetAllScreening{id}", GetScreeningsByMovieId);
        }

        private static async Task<IResult> GetScreeningsByMovieId(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task<IResult> CreateScreeningByMovieId(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
