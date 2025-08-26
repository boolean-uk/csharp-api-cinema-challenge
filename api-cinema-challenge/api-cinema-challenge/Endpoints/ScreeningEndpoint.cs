using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screening = app.MapGroup("movies/");

            screening.MapGet("{id}/screenings", GetAll);
            screening.MapPost("{id}/screenings", Create);
        }

        public static ScreeningGet ScreenToScreeningGet(Screening s)
        {
            ScreeningGet screenShow = new ScreeningGet() { MovieId = s.MovieId, ScreenNumber = s.ScreenNumber, Capacity = s.Capacity, StartsAt = s.StartsAt, CreatedAt = s.CreatedAt, UpdatedAt = s.UpdatedAt };
            return screenShow;
        }

        [Authorize(Roles = "Admin,User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Screening> screenRepo, int id)
        {
            List<ScreeningGet> response = new List<ScreeningGet>();
            var all_results = await screenRepo.GetAll();
            var results = all_results.Where(s => s.MovieId == id);
            foreach (Screening s in results)
            {
                ScreeningGet screenShow = ScreenToScreeningGet(s);
                response.Add(screenShow); 
            }
            return TypedResults.Ok(response);
        }

        /*
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository<Movie> screenRepo, int id)
        {
            List<ScreeningGet> response = new List<ScreeningGet>();
            var movie = await screenRepo.GetWithIncludes(m => m.Screenings);
            var results = await screenRepo.GetAll();
            foreach (Screening s in results)
            {
                if (s.MovieId == id)
                {
                    ScreeningGet screenShow = ScreenToScreeningGet(s);
                    response.Add(screenShow);
                }
            }
            return TypedResults.Ok(response);
        }
        */
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> Create(IRepository<Screening> screenRepo, ScreeningPost sModel, int id)
        {
            DateTime time = DateTime.UtcNow.ToUniversalTime();
            Screening newScreen = new Screening()
            {
                MovieId = id,
                ScreenNumber = sModel.ScreenNumber,
                Capacity = sModel.Capacity,
                StartsAt = sModel.StartsAt,
                CreatedAt = time,
                UpdatedAt = time
            };
            await screenRepo.Insert(newScreen);
            return TypedResults.Created($"Created object with id: {newScreen.Id}");
        }
    }
}
