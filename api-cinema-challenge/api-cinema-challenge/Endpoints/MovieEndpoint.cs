using api_cinema_challenge.Models.DTO.MovieDTOs;
using api_cinema_challenge.Models.DTO.ScreeningDTOs;
using api_cinema_challenge.Models.Other;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            RouteGroupBuilder movieGroup = app.MapGroup("movies");
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPut("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
            movieGroup.MapGet("/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(CreateMovieDTO cDTO, IMovieRepository repository)
        {
            GetMovieDTO result = await repository.CreateMovie(cDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Invalid input for creating a movie." };
                return TypedResults.BadRequest(errorResponse);
            }
            ApiResponseType<GetMovieDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Created("", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository)
        {
            List<GetMovieDTO> result = await repository.GetAllMovies();
            ApiResponseType<List<GetMovieDTO>> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(int id, UpdateMovieDTO uDTO, IMovieRepository repository)
        {
            GetMovieDTO? result = await repository.UpdateMovie(id, uDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Could not find movie with id: {id}" };
                return TypedResults.NotFound(errorResponse);
            }
            ApiResponseType<GetMovieDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(int id, IMovieRepository repository)
        {
            GetMovieDTO? result = await repository.DeleteMovie(id);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Could not find movie with id: {id}" };
                return TypedResults.NotFound(errorResponse);
            }
            ApiResponseType<GetMovieDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(int id, CreateScreeningDTO cDTO, IScreeningRepository repository)
        {
            GetScreeningDTO result = await repository.CreateScreening(id, cDTO);
            if (result == null)
            {
                ApiResponseType<string> errorResponse = new() { Status = ApiResponseCodes.Failure, Data = $"Cannot find movie with id {id}." };
                return TypedResults.BadRequest(errorResponse);
            }
            ApiResponseType<GetScreeningDTO> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Created("", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(int id, IScreeningRepository repository)
        {
            List<GetScreeningDTO> result = await repository.GetScreenings(id);
            ApiResponseType<List<GetScreeningDTO>> response = new() { Status = ApiResponseCodes.Success, Data = result };
            return TypedResults.Ok(response);
        }
    }
}
