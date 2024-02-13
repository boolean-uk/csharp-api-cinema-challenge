using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.DTO.Entities.MoviesAndScreenings;
using api_cinema_challenge.Models.DTO;
using api_cinema_challenge.Models.Domain.Entities.SalesAndTickets;
using api_cinema_challenge.Repository.Generic;
using api_cinema_challenge.Models.Domain.Entities.CinemaInfrastructure;
using api_cinema_challenge.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var group = app.MapGroup("movies");
            group.MapGet("/", GetAll);
            group.MapPost("/", CreateMovie);
            group.MapPut("/{id}", Update);
            group.MapDelete("/{id}", Delete);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAll(IRepository<Movie> movieRepository)
        {
            IEnumerable<Movie> results = await movieRepository.GetAll();
            List<MovieOutputDTO> resultDTOs = new List<MovieOutputDTO>();
            foreach (Movie movie in results)
            {
                resultDTOs.Add(new MovieOutputDTO(movie));
            }
            return TypedResults.Ok(new Payload<List<MovieOutputDTO>>(resultDTOs));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Update(IRepository<Movie> movieRepository, int id, MoviePutDTO input)
        {
            Movie? movie = await movieRepository.GetById(id);
            if (movie == null) return TypedResults.NotFound($"Could not find any movie with id={id}.");
            movie.Title = input.Title;
            movie.Rating = input.Rating;
            movie.Description = input.Description;
            movie.RuntimeMins = input.RuntimeMins;
            movie.UpdatedAt = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
            MovieOutputDTO resultDTO = new MovieOutputDTO(movie);
            return TypedResults.Created($"/{movie.Id}", new Payload<MovieOutputDTO>(resultDTO));
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> Delete(IRepository<Movie> movieRepository, int id)
        {
            Movie? result = await movieRepository.DeleteById(id);
            if (result == null) return TypedResults.NotFound($"Could not find any movie with id={id}.");
            MovieOutputDTO resultDTO = new MovieOutputDTO(result);
            return TypedResults.Ok(new Payload<MovieOutputDTO>(resultDTO));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateMovie(
            [FromServices] IRepository<Movie> movieRepository,
            [FromServices] IRepository<Screening> screeningRepository,
            [FromServices] IRepository<Auditorium> auditoriumRepository,
            [FromServices] IJunctionRepository<ScreeningSeat> screeningSeatRepository,
            [FromBody] MoviePostDTO input)
        {
            foreach (ScreeningInputDTO screening in input.Screenings)
            {
                if (!DateTime.TryParse(screening.StartsAt, out DateTime parsed)) return TypedResults.BadRequest($"{screening.StartsAt} is not a valid date.");
                Auditorium? auditorium = await auditoriumRepository.GetById(screening.ScreenNumber);
                if (auditorium == null) return TypedResults.NotFound(($"No screen with id = {screening.ScreenNumber}"));
            }
            Movie newMovie = new Movie()
            {
                Title = input.Title,
                Rating = input.Rating,
                Description = input.Description,
                RuntimeMins = input.RuntimeMins,
            };
            Movie movieResult = await movieRepository.Insert(newMovie);
            List<ScreeningInsertResultDTO> insertedScreenings = new List<ScreeningInsertResultDTO>();
            if (input.Screenings.Count > 0)
            {
                foreach (var screening in  input.Screenings)
                {
                    insertedScreenings.Add(await CreateScreening(screeningRepository, auditoriumRepository, screeningSeatRepository, movieResult.Id, screening));
                }
            }
            return TypedResults.Created($"/{movieResult.Id}", new MovieWithScreeningsOutputDTO(movieResult, insertedScreenings));
        }

        private static async Task<ScreeningInsertResultDTO> CreateScreening(
                IRepository<Screening> screeningRepository,
                IRepository<Auditorium> auditoriumRepository,
                IJunctionRepository<ScreeningSeat> screeeningSeatRepository,
                int movieId,
                ScreeningInputDTO input)
        {
            Auditorium? auditorium = await auditoriumRepository.GetById(input.ScreenNumber);
            ScreeningCreator screeningCreator = new ScreeningCreator(movieId, auditorium, input.Capacity, DateTime.Parse(input.StartsAt));
            Screening screeningResult = await screeningRepository.Insert(screeningCreator.GetScreening());
            IEnumerable<ScreeningSeat> screeningSeatsResult = await screeeningSeatRepository.Insert(screeningCreator.GetScreeningSeats(screeningResult.Id));
            return new ScreeningInsertResultDTO(screeningResult, auditorium.Id, screeningSeatsResult.Count());
        }
    }
}
