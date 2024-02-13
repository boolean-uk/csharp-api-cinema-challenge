using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Service;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        //TODO:  add additional endpoints in here according to the requirements in the README.md 
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/movies", GetMovies);
            cinemaGroup.MapGet("/movie/{id}", GetMovieById);
            cinemaGroup.MapPost("/movie", CreateMovie);
            cinemaGroup.MapPut("/movie/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movie/{id}", DeleteMovie);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository, IService service)
        {
            var data = await repository.Get();
            var output = await service.MultipleToDto<Movie, MovieDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> repository, IService service, int id)
        {
            var data = await repository.GetById(id);
            if(data == null) { return TypedResults.NotFound("Movie not found"); }
            var output = await service.SingleToDto<Movie, MovieDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, IService service, MoviePost input)
        {
            if (repository.Get().Result.Any(x => x.MovieName == input.Name)) 
            {
                return TypedResults.BadRequest("Movie already exists.");
            }
            Movie movie = new Movie()
            {
                MovieName = input.Name,
                MovieDesc = input.Desc,
                MovieLength = input.Length,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var data = await repository.Create(movie);
            var output = await service.SingleToDto<Movie, MovieDto>(data);
            return TypedResults.Created($"/{data.Id}",output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, IService service, int id, MoviePut input)
        {
            Movie movie = await repository.GetById(id);
            if (repository.Get().Result.Any(x => x.MovieName == input.Name) && movie.MovieName != input.Name)
            {
                return TypedResults.BadRequest("Movie already exists.");
            }
            if (movie == null) { return TypedResults.NotFound("Movie not found"); }
            movie.MovieName = input.Name;
            movie.MovieDesc = input.Desc;
            movie.MovieLength = input.Length;
            movie.UpdatedAt = DateTime.UtcNow;
            var data = await repository.Update(movie);
            var output = await service.SingleToDto<Movie, MovieDto>(data);
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, IService service, int id)
        {
            if (await repository.GetById(id) == null) { return TypedResults.NotFound("Movie not found"); }
            var data = await repository.Delete(id);
            var output = await service.SingleToDto<Movie, MovieDto>(data);
            return TypedResults.Ok(output);
        }
    }
}