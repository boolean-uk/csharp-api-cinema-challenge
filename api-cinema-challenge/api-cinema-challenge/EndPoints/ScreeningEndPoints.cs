using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.DTOs;

namespace workshop.wwwapi.Endpoints
{
    public class ScreeningPayload
    {



        public int? ScreenId { get; set; }


        public DateTime? StartsAt { get; set; }


        public bool AllFieldsFilled()
        {


            if(!ScreenId.HasValue) { return false; }
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
            movieGroup.MapGet("/screenings", GetAllScreenings);
            movieGroup.MapGet("/{id}/screenings", GetAllScreeningsForMovieByID);
            //movieGroup.MapGet("/{MovieId}/screenings/{ScreeningId}", DeleteScreening);

        }

        public static async Task<IResult> GetAllScreenings(IScreeningRepository repository)
        {

            List<Screening> screenings = await repository.GetScreenings();
            if (screenings.Count == 0) { return TypedResults.NotFound(); }

            return Results.Ok(ScreeningDTO.FromScreenings(screenings));
        }

        public static async Task<IResult> GetAllScreeningsForMovieByID(int MovieId, IScreeningRepository repository,IMovieRepository movieRepo)
        {
            if (await movieRepo.GetMovieById(MovieId) == null) { return TypedResults.NotFound(); }
            

            List<Screening> screenings = await repository.GetScreeningsByMovieId(MovieId);
            if (screenings.Count == 0) { return TypedResults.NotFound(); }

            return Results.Ok(ScreeningDTO.FromScreenings(screenings));
        }


        public static async Task<IResult> CreateScreeningForMovie(int MovieId,ScreeningPayload payload, IScreeningRepository ScreeningRepository,  IMovieRepository movieRepo, IScreenRepository screenRepo)
        {
            if (!payload.AllFieldsFilled()) return Results.BadRequest("All fields are required.");
            if (await movieRepo.GetMovieById(MovieId) == null) { return TypedResults.NotFound(); }
            if (await screenRepo.GetScreenById(payload.ScreenId.Value) == null) { return TypedResults.NotFound(); }
            

            
            Screening newScreening = new Screening
            {
                MovieId = MovieId,
                ScreenId = payload.ScreenId.Value,
                StartsAt = payload.StartsAt.Value,

            };




            Screening? createdScreening = await ScreeningRepository.CreateAScreeningForMovieId(newScreening, MovieId);
            return Results.Created($"/movies/{createdScreening.Id}", ScreeningDTO.FromScreening(createdScreening));
        }

       /* public static async Task<IResult> DeleteScreening(int MovieId, int ScreeningId,  IScreeningRepository repository, IMovieRepository movieRepo)
        {
            if (await movieRepo.GetMovieById(MovieId) == null) { return TypedResults.NotFound(); }

            await repository.
            if (screenings.Count == 0) { return TypedResults.NotFound(); }

            return Results.Ok(ScreeningDTO.FromScreenings(screenings));


        }*/

    }
}