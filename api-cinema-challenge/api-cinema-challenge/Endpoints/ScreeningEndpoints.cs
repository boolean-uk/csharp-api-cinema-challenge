using api_cinema_challenge.DTOs.Screening;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class ScreeningEndpoints
    {
        public static void ConfigureScreeningEndpoints(this WebApplication app)
        {
            var screenings = app.MapGroup("/screenings");
            screenings.MapGet("/movie/{id}", GetAllScreeningsByMovieId);
            screenings.MapPost("/movie{id}", CreateScreeningForMovie);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> GetAllScreeningsByMovieId(IScreeningRepository screeningRepository, int id)
        {
            try
            {
                var result = await screeningRepository.GetScreeningsByMovieId(id);

                if (result == null)
                {
                    return TypedResults.NotFound($"Screenings for movie with id {id} not found!");
                }

                List<GetScreeningDTO> screeningDTOs = new List<GetScreeningDTO>();

                foreach (var screen in result)
                {
                    GetScreeningDTO screeningDTO = new GetScreeningDTO()
                    {
                        Id = screen.Id,
                        ScreenNumber = screen.ScreenNumber,
                        Capacity = screen.Capacity,
                        MovieId = screen.MovieId,
                        MovieTitle = screen.Movie.Title,
                        NumOfTicketsSold = screen.Tickets.Count,
                        StartsAt = screen.StartsAt,
                        CreatedAt = screen.CreatedAt,
                        UpdatedAt = screen.UpdatedAt
                    };

                    screeningDTOs.Add(screeningDTO);
                }

                Payload<IEnumerable<GetScreeningDTO>> payload = new Payload<IEnumerable<GetScreeningDTO>>();
                payload.data = screeningDTOs;
                payload.status = System.Net.HttpStatusCode.OK;

                return TypedResults.Ok(payload);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreeningForMovie(IScreeningRepository screeningRepository, IMovieRepository movieRepository, PostScreeningDTO newScreening)
        {
            try
            {
                var target = await movieRepository.GetMovieById(newScreening.MovieId);

                if (target == null)
                {
                    return TypedResults.NotFound($"Movie with id {newScreening.MovieId} not found!");
                }

                Screening screening = new Screening()
                { 
                    ScreenNumber = newScreening.ScreenNumber,
                    Capacity = newScreening.Capacity,
                    MovieId = newScreening.MovieId,
                    StartsAt = newScreening.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var result = await screeningRepository.CreateScreening(screening);

                GetScreeningDTO screeningDTO = new GetScreeningDTO()
                {
                    Id = result.Id,
                    ScreenNumber = result.ScreenNumber,
                    Capacity = result.Capacity,
                    MovieId = result.MovieId,
                    MovieTitle = result.Movie.Title,
                    NumOfTicketsSold = result.Tickets.Count,
                    StartsAt = result.StartsAt,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                Payload<GetScreeningDTO> payload = new Payload<GetScreeningDTO>();
                payload.data = screeningDTO;
                payload.status = System.Net.HttpStatusCode.Created;
                var path = $"/screenings/movie/{result.MovieId}";

                return TypedResults.Created(path, payload);

            }
            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex.Message);
            }
        }

    }
}
