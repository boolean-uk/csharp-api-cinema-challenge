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
            screenings.MapPut("/{id}", UpdateScreening);
            screenings.MapDelete("/{id}", DeleteScreening);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddScreening(IRepository<Screening> screeningRepository, IRepository<Movie> movieRepository, int movieId, ScreeningPost screening)
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

            var movie = await movieRepository.Get(movieId);
            if (movie == null)
            {
                return TypedResults.NotFound($"Movie with id {movieId} was not found");
            }

            Screening newScreening = new Screening
            {
                ScreenNumber = screening.ScreenNumber.Value,
                Capacity = screening.Capacity.Value,
                AvailableSeats = screening.Capacity.Value,
                Movie = movie,
                MovieId = movieId,
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

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateScreening(IRepository<Screening> screeningRepository, 
            IRepository<Movie> movieRepository, IRepository<Ticket> ticketRepository, 
            int screeningId, ScreeningPut screening)
        {
            if (screeningRepository == null)
            {
                return TypedResults.BadRequest("Invalid input: missing screening");
            }

            var oldScreening = await screeningRepository.Get(screeningId);
            if (oldScreening == null)
            {
                return TypedResults.BadRequest($"Screening with id {screeningId} was not found");
            }

            if (screening.MovieId != null) 
            {
                var movie = await movieRepository.Get(screening.MovieId.Value);
                if (movie == null)
                {
                    return TypedResults.NotFound($"Movie with movie id {screening.MovieId} was not found");
                }

                if (screening.Capacity != null && screening.Capacity != oldScreening.Capacity)
                {
                    var tickets = await ticketRepository.GetAll();
                    var movieTickets = tickets.Where(x => x.ScreeningId == screeningId).ToList();

                    int totalTickets = 0;
                    foreach (Ticket ticket in movieTickets)
                    {
                        totalTickets += ticket.NumberOfSeats;
                    }

                    if (totalTickets < screening.Capacity)
                    {
                        return TypedResults.BadRequest($"The capacity is too small for the number of seats booked. A minimum capacity of {totalTickets} is needed");
                    }
                    oldScreening.Capacity = screening.Capacity.Value;
                    oldScreening.AvailableSeats = oldScreening.Capacity - totalTickets;
                }

                oldScreening.MovieId = screening.MovieId.Value;
                oldScreening.Movie = movie;
            }

            if (screening.Capacity != null) { oldScreening.Capacity = screening.Capacity.Value; }
            if (screening.StartsAt != null) { oldScreening.StartsAt = screening.StartsAt.Value; }
            oldScreening.UpdatedAt = DateTime.UtcNow;

            var changedScreening = await screeningRepository.Update(oldScreening);

            return TypedResults.Created($"/{screeningId}", Screening.ToDTO(changedScreening));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteScreening(IRepository<Screening> repository, int screeningId)
        {
            var deletedScreening = await repository.Delete(screeningId);
            if (deletedScreening == null)
            {
                return TypedResults.NotFound($"Screening with id {screeningId} was not found");
            }

            return TypedResults.Ok(Screening.ToDTO(deletedScreening));
        }
    }
}