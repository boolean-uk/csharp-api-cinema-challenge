using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningsEndpoints
    {
        public static void ConfigureScreenings(this WebApplication app)
        {
            var customers = app.MapGroup("/movies/{movieId}/screenings");

            customers.MapPost("/", Insert);
            customers.MapGet("/", GetAll);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> Insert(IRepository<Screening> repository, IRepository<Movie> movieRepository, IMapper mapper, int movieId, ScreeningPostDTO screening)
        {
            try
            {
                var movieTarget = await movieRepository.GetById(movieId);
                if (movieTarget == null)
                    return TypedResults.NotFound($"Movie with id {movieId} does not exist.");

                Screening insert = new Screening()
                {
                    MovieId = movieId,
                    ScreenNumber = screening.ScreenNumber,
                    Capacity = screening.Capacity,
                    StartsAt = screening.StartsAt
                };

                await repository.Insert(insert);

                var insertDTO = mapper.Map<ScreeningDTO>(insert);

                return TypedResults.Created($"https://localhost:7195/screenings/{insert.Id}", insertDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAll(IRepository<Screening> repository, IRepository<Movie> movieRepository, IMapper mapper, int movieId)
        {
            try
            {
                var movieTarget = await movieRepository.GetById(movieId);
                if (movieTarget == null)
                    return TypedResults.NotFound($"Movie with id {movieId} does not exist.");

                var screenings = repository.Get().Result.Where(s => s.MovieId == movieId);

                var response = mapper.Map<List<ScreeningDTO>>(screenings);

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
