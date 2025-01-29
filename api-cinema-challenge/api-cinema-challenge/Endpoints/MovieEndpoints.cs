using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoints
    {
        public static void ConfigureMovieEndpoints(this WebApplication app)
        {
            var movies = app.MapGroup("movies");

            movies.MapGet("/", GetAllMovies);
            movies.MapPost("/", CreateMovie);
            movies.MapPut("/{id}", UpdateMovie);
            movies.MapDelete("/{id}", DeleteMovie);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> rep, IMapper mapper)
        {
            try
            {
                var movies = await rep.GetAll(null, null);

                var response = mapper.Map<ResponseDTO<MovieDTO>>(movies);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repMovies, IMapper mapper, MoviePOST model)
        {
            try
            {
                var movie = mapper.Map<Movie>(model);

                await repMovies.Create(movie);

                if (model.Screenings != null && model.Screenings.Any()) 
                { 
                    var responseWScreenings = mapper.Map<ResponseSingleDTO<MovieWScreeningsDTO>>(movie);

                    return TypedResults.Ok(responseWScreenings);
                }

                var response = mapper.Map<ResponseSingleDTO<MovieDTO>>(movie);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> rep, IMapper mapper, int id, MoviePUT model)
        {

            try
            {
                var movie = await rep.GetById(id);
                if (movie == null) return TypedResults.NotFound("No movie with matching ID");

                movie = mapper.Map(model, movie);
                movie.UpdatedAt = DateTime.UtcNow;
                await rep.Update(movie);

                var response = mapper.Map<ResponseSingleDTO<MovieDTO>>(movie);

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> rep, IMapper mapper, int id)
        {
            try
            {
                var movie = await rep.GetById(id);
                if (movie == null) return TypedResults.NotFound("No customer with matching ID");

                await rep.Delete(movie);

                var response = mapper.Map<ResponseSingleDTO<MovieDTO>>(movie);
                response.Status = "Successfully deleted";

                return TypedResults.Ok(response);
            }
            catch (Exception ex) { return TypedResults.Problem(ex.Message); }
        }
    }
}
