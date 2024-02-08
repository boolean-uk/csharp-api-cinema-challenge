using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models.Posts;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var screenings = app.MapGroup("screenings");

            screenings.MapPost("/{id}", AddScreening);
            screenings.MapGet("", GetAllScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddScreening(IRepository<Screening> screeningRepository, IRepository<Movie> movieRepository, int id, ScreeningPost screening)
        {
            if (screening == null)
            {
                return TypedResults.BadRequest("Invalid input: missing screening");
            }
            if (screening.ScreenNumber == null)
            {
                return TypedResults.BadRequest("Invalid input: please enter a screen number");
            }
            if (screening.Capacity == null)
            {
                return TypedResults.BadRequest("Invalid input: please enter a capactiy");
            }
            if (screening.StartsAt == null)
            {
                return TypedResults.BadRequest("Invalid input: please enter a starting time");
            }

            var movie = await movieRepository.Get(id);
            if (movie == null)
            {
                return TypedResults.NotFound($"Movie with id {id} was not found");
            }

            Screening newScreening = new Screening
            {
                ScreenNumber = screening.ScreenNumber.Value,
                Capacity = screening.Capacity.Value,
                AvailableSeats = screening.Capacity.Value,
                Movie = movie,
                MovieId = id,
                StartsAt = screening.StartsAt.Value,
            };

            movie.Screenings.Add(newScreening);

            var addedScreening = await screeningRepository.Add(newScreening);

            return TypedResults.Created($"/{addedScreening.Id}", Screening.ToDTO(addedScreening));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IRepository<Movie> repository, IRepository<Screening> screeningRepository, int id)
        {
            var movie = await repository.Get(id);

            if (movie == null)
            {
                return TypedResults.Ok($"Movie with id {id} was not found");
            }

            var screenings = await screeningRepository.GetAll();

            return TypedResults.Ok(Screening.ToDTO(screenings.Where(x => x.MovieId == movie.Id).ToList()));
        }
    }
}