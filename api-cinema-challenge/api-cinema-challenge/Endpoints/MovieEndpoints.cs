using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {

        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapGet("/", GetMovies);
            movieGroup.MapPost("/", AddMovie);
            movieGroup.MapPatch("/{id}", UpdateMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IMovieRepository repository, IMapper mapper)
        {
            var movies = await repository.GetAllMovies();
            var movieDtos = mapper.Map<IEnumerable<GetMovieDTO>>(movies);

            var payload = new Payload<IEnumerable<GetMovieDTO>>
            {
                Data = movieDtos
            };

            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> AddMovie(IMovieRepository repository, IMapper mapper, PostMovieDTO movieDTO)
        {
            Movie movie = mapper.Map<Movie>(movieDTO);
            var createdMovie = await repository.AddMovie(movie);
            var getMovieDto = mapper.Map<GetMovieDTO>(createdMovie);
            var location = $"/movies/{createdMovie.Id}";

            var payload = new Payload<GetMovieDTO>
            {
                Data = getMovieDto
            };

            return TypedResults.Created(location, payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IMovieRepository repository, IMapper mapper, PatchMovieDTO movieDTO, int id)
        {
            Movie movie = mapper.Map<Movie>(movieDTO);
            Movie updatedMovie = null;
            try
            {
                updatedMovie = await repository.UpdateMovie(id, movie);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }

            var getMovieDto = mapper.Map<GetMovieDTO>(updatedMovie);
            var location = $"/movies/{updatedMovie.Id}";

            var payload = new Payload<GetMovieDTO>
            {
                Data = getMovieDto
            };

            return TypedResults.Created(location, payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IMovieRepository repository, IMapper mapper, int id)
        {
            Movie deletedMovie = null;

            try
            {
                deletedMovie = await repository.DeleteMovie(id);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }

            var getMovieDto = mapper.Map<GetMovieDTO>(deletedMovie);

            var payload = new Payload<GetMovieDTO>
            {
                Data = getMovieDto
            };

            return TypedResults.Ok(payload);
        }

    }
}
