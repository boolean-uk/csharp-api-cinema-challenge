

using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models.PayLoad;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("movies/{id}/screenings");

            screenings.MapPost("", PostScreening);
            screenings.MapGet("", GetAllScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> PostScreening(IRepository<Screening> screeningRepo, IRepository<Movie> movieRepo, ScreeningPost model, int id)
        {
            // Retrieve the movie by its id
            var movie = await movieRepo.SelectById(id);
            if (movie == null)
            {
                return TypedResults.NotFound("Movie not found");
            }

            // Map the model to a DTO
            var screeningDTO = DTOHelper.MapToDTO<ScreeningDTO>(model);

            // Create a payload to return
            var payload = new PayLoad1<ScreeningDTO>
            {
                data = screeningDTO,
                status = DTOHelper.PropertyChecker<CustomerDTO>(screeningDTO)
            };

            // Check if the DTO properties are valid
            if (payload.status == "success")
            {
                // Insert the new customer into the database
                var ScreeningToInsert = DTOHelper.MapToEntity<Screening>(model, "create");
                //REMEMBER THE MOOOOVIE
                ScreeningToInsert.MovieId = id;
                var screening = await screeningRepo.Insert(ScreeningToInsert);

                //Give the DTO the new id
                payload.data = DTOHelper.MapToDTO<ScreeningDTO>(screening);

                // Return the payload
                return TypedResults.Created($"/{payload.data.Id}", payload);
            }
            else
            {
                // Return the payload
                return TypedResults.BadRequest(payload);
            }
        }

        private static async Task<IResult> GetAllScreenings(IRepository<Screening> screeningRepo, IRepository<Movie> movieRepo, int id)
        {
            // Retrieve the movie by its id
            var movie = await movieRepo.SelectById(id);
            IEnumerable<ScreeningDTO> screeningDTOs = new List<ScreeningDTO>();
            var payload = new PayLoad1<IEnumerable<ScreeningDTO>>
            {
                data = screeningDTOs
            };

            if (movie == null)
            {
                payload.status = "Movie not found";
                return TypedResults.NotFound(payload);
            }

            // Retrieve all screenings of the specified movie
            var screenings = await screeningRepo.SelectWhere(s => s.MovieId == id);
            screeningDTOs = screenings.Select(s => DTOHelper.MapToDTO<ScreeningDTO>(s));
            payload.data = screeningDTOs;

            return TypedResults.Ok(payload);
        }
    }
}
