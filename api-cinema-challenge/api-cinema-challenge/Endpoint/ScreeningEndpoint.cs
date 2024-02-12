using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoint
{
    public static class ScreeningEndpoint
    {
        public static void ConfigureScreeningEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie/");

            movieGroup.MapGet("{id}/screenings", GetScreenings);
            movieGroup.MapPost("{id}/screenings", AddScreening);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IRepository<Movie> repo, int id)
        {
            var screenings = await repository.Get();

            var validScreenings = screenings.Where(x => x.MovieId == id);

            List<ScreeningDTO> screeningsDTO = new List<ScreeningDTO>();
            foreach (var screening in validScreenings)
            {
                var movie = await repo.GetById(screening.MovieId);

                screeningsDTO.Add(new ScreeningDTO()
                {
                    MovieName = movie.Title,
                    Capacity = screening.Capacity,
                    ScreenNum = screening.ScreenNum,
                    StartTime = screening.StartTime
                });
            }

            return TypedResults.Ok(screeningsDTO);
            //return TypedResults.Ok(validScreenings);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddScreening(IRepository<Screening> repository, IRepository<Movie> repo, int id, ScreeningInputDTO input)
        {

            Screening Screen = new Screening()
            {
                MovieId = id,
                Capacity = input.Capacity,
                ScreenNum = input.ScreenNum,
                StartTime = input.StartTime,
                TimeCreated = DateTime.UtcNow,
                TimeUpdated = DateTime.UtcNow
            };

            Screening accepted = await repository.Insert(Screen);

            var movie = await repo.GetById(accepted.MovieId);
            ScreeningDTO acceptedDTO = new ScreeningDTO()
            {
                MovieName = movie.Title,
                Capacity = accepted.Capacity,
                ScreenNum = accepted.ScreenNum,
                StartTime = accepted.StartTime
            };

            return TypedResults.Ok(acceptedDTO);
        }

    }
}
