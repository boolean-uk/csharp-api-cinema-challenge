using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace workshop.wwwapi.Endpoints
{
    public class ScreeningPayload
    {
        public int? ScreenNumber { get; set; }
        public int? Capacity { get; set; }
        public DateTime? StartsAt { get; set; }


        public bool AllFieldsFilled()
        {

            if(!ScreenNumber.HasValue) { return false; }
            if(!Capacity.HasValue) { return false; }
            if(!StartsAt.HasValue) { return false; }


            return true;
        }
    }
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapPost("/{id}/screenings", CreateScreeningForMovie);
            movieGroup.MapGet("/{id}/screenings", GetAllScreeningsForMovie);

        }

        public static async Task<IResult> GetAllScreeningsForMovie(int MovieId, IScreeningRepository repository, IMovieRepository movieRepo)
        {
            if (await movieRepo.GetMovieById(MovieId) == null) { return TypedResults.NotFound(); }

            List<Screening> screenings = await repository.GetAllScreeningsByMovieId(MovieId);
            if (screenings.Count == 0) { return TypedResults.NotFound(); }

            return Results.Ok(screenings);
        }


        public static async Task<IResult> CreateScreeningForMovie(int MovieId,ScreeningPayload payload, IScreeningRepository ScreeningRepository, IMovieRepository movieRepo)
        {
            if (await movieRepo.GetMovieById(MovieId) == null) { return TypedResults.NotFound(); }

            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");

            
            Screening newScreening = new Screening
            {
                ScreenNumber = payload.ScreenNumber.Value,
                Capacity = payload.Capacity.Value,
                StartsAt = payload.StartsAt.Value,

            };

            Screening? createdScreening = await ScreeningRepository.CreateAScreeningForMovieId(newScreening, MovieId);
            return Results.Created($"/movies/{createdScreening.Id}", createdScreening);
        }


    }
}