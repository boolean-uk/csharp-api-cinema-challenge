using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Model;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;

namespace api_cinema_challenge.Endpoint
{
    public static class MovieEndpoint
    {        
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie");
            movieGroup.MapPost("/create", Create);
            movieGroup.MapGet("/get", Get);
            movieGroup.MapPut("/update", Update);
            movieGroup.MapDelete("/delete", Delete);
        }

        public static async Task<IResult> Create(IRepository<Movie> repository, createMovie movieInfo) 
        {
            Movie movie = new Movie()
            {
                Title = movieInfo.Title,
                Description = movieInfo.Description,
                Rating = movieInfo.Rating,
                RuntimeMins = movieInfo.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            Movie movieAdded = await repository.Add(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Status = "success",
                Data = movieAdded,
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Get(IRepository<Movie> repository) 
        {
            var movies = await repository.Get();
            Payload<List<Movie>> payload = new Payload<List<Movie>>()
            {
                Status = "success",
                Data = movies
            };
            return TypedResults.Ok(payload);
        }

        public static async Task<IResult> Update(IRepository<Movie> repository, int id, createMovie movieInfo)
        {
            Movie movie = await repository.GetById(id);
            movie.Title = movieInfo.Title;
            movie.Description = movieInfo.Description;
            movie.Rating = movieInfo.Rating;
            movie.RuntimeMins = movieInfo.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            Movie updatedMovie = await repository.Update(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Data = updatedMovie,
                Status = "success"
            };
            return TypedResults.Ok(payload);
        }
        public static async Task<IResult> Delete(IRepository<Movie> repository, int id) 
        {
            var movies = await repository.Get();
            Movie? movie = movies.Find(x => x.Id == id);
            if (movie == null) { return TypedResults.NotFound($"Movie with id {id} could not be found"); }
            Movie deletedMovie = await repository.Delete(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Status = "success",
                Data = deletedMovie
            };
            return TypedResults.Ok(payload);
        }
    }
}
