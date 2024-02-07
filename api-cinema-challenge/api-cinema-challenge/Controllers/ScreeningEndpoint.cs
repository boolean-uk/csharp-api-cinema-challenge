using Microsoft.AspNetCore.Mvc;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.Conventions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;

namespace api_cinema_challenge.Controllers
{

    public static class ScreeningEndpoint {

        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            app.MapGet("movies/{id}/screenings", GetScreenings);
            app.MapPost("movies/{id}/screenings", AddScreening);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            throw new NotImplementedException();
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddScreening(IRepository repository, PostScreening model)
        {
            throw new NotImplementedException();
        }

    }
}
