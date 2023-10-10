using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.EndPoints
{
    public static class ScreeningApi
    {
        public static void ConfigureScreeningApi(this WebApplication app)
        {
            app.MapPost("/movies/{id}/screenings", CreateScreening);
            app.MapGet("/movies/{id}/screenings", GetScreenings);
        }

        /// <summary>Create a screening for an existing movie.</summary>
        /// <returns>
        /// Status 201 - Screening object created
        /// </returns>
        [ProducesResponseType(StatusCodes.Status201Created)]
        private static Task CreateScreening(int id, ScreeningPost s, IScreeningRepository service)
        {
            throw new NotImplementedException();
        }

        /// <summary>Get a list of every screening for a movie.</summary>
        /// <returns>
        /// Status 200 - List of all screenings for a movie
        /// </returns>
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static Task GetScreenings(int id, IScreeningRepository service)
        {
            throw new NotImplementedException();
        }
    }
}
