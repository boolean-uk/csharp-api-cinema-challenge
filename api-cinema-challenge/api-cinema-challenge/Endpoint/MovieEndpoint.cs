using Microsoft.AspNetCore.Http.HttpResults;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Model;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Payloads;
using System.ComponentModel;
using System.Diagnostics;

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
            movieGroup.MapGet("/test", test);
        }

        public static async Task<IResult> Create(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, MoviePost movieInfo) 
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
            Movie movieAdded = await movieRepository.Add(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Status = "success",
                Data = movieAdded,
            };

            if (movieInfo.Screenings.Count > 0) 
            {
                var screenings = movieInfo.Screenings.Select(x => new Screening()
                {
                    ScreenNumber = x.ScreeningNumber,
                    Capacity = x.Capacity,
                    StartsAt = x.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = movieAdded.Id                    
                });
                await screeningRepository.AddRange(screenings);
            }
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
            movie.Title = movieInfo.Title == string.Empty ? movie.Title : movieInfo.Title;
            movie.Description = movieInfo.Description == string.Empty ? movie.Description : movieInfo.Description;
            movie.Rating = movieInfo.Rating == string.Empty ? movie.Rating : movieInfo.Rating;
            movie.RuntimeMins = movieInfo.RuntimeMins <= 0 ? movie.RuntimeMins : movieInfo.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            Movie updatedMovie = await repository.Update(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Data = updatedMovie,
                Status = "success"
            };
            return TypedResults.Ok(payload);
        }
        public static async Task<IResult> Delete(IRepository<Movie> movieRepository, IRepository<Screening> screeningRepository, int id) 
        {
            var screenings = await screeningRepository.Get();
            var screeningsToBeDeleted = screenings.Where(s => s.MovieId == id);
            await screeningRepository.DeleteRange(screeningsToBeDeleted);
          
            var movie = await movieRepository.GetById(id);                       
            Movie deletedMovie = await movieRepository.Delete(movie);
            Payload<Movie> payload = new Payload<Movie>()
            {
                Status = "success",
                Data = deletedMovie
            };
            return TypedResults.Ok(payload);
        }
        
        public static bool test() 
        {
            string s = "";

            if (s == string.Empty) { Debug.WriteLine("begge er tomme"); }
            return true; 
        }
    }
}
