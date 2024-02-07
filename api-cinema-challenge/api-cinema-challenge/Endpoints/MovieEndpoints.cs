using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var surgeryGroup = app.MapGroup("movies");

            surgeryGroup.MapGet("/patients", GetMovies);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
