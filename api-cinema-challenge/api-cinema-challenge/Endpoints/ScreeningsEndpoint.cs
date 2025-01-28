
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace workshop.wwwapi.Endpoints
{
    public static class ScreeningsEndpoint
    {
        public static void ConfigureScreeningsEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("/movies/{id}/screenings");
            screenings.MapPost("/", CreateAScreening);
            screenings.MapGet("/", GetAllScreenings);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAllScreenings( IRepository<Screenings> repo, int movieId)
        {
            throw new NotImplementedException();
        }
        

        [ProducesResponseType(StatusCodes.Status201Created)]
        private static async Task<IResult> CreateAScreening(HttpContext context, IRepository<Screenings> repo, int movieId)
        {
            throw new NotImplementedException();
        }


    }
}
