using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {

            app.MapGet("movies/{id}/screenings", GetScreenings);
            app.MapPost("movies/{id}/screenings", CreateScreening);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreenings(IRepository<Movie> repository, int id)
        {
            Movie movie = await repository.Get(id);
            if (movie == null || !movie.Screenings.Any()) return TypedResults.NotFound();
            return TypedResults.Ok(new Payload<List<Screening>>(movie.Screenings));
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository,
            IRepository<Movie> movieRepository, ScreeningDto screeningDto, int movieId)
        {
            if (screeningDto.ScreenNumber <= 0 ||
                screeningDto.Capacity <= 0) return TypedResults.BadRequest();

            if (await movieRepository.Get(movieId) == null)
                return TypedResults.NotFound();

            Screening screening = Service.ScreeningService.toScreening(screeningDto, movieId);
            Screening result = await repository.Create(screening);
            return TypedResults.Created($"screening/{result.Id}", new Payload<Screening>(result));
        }
    }

}
