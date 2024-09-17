

using api_cinema_challenge.DTO;
using api_cinema_challenge.Helpers;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var MovieGroup = app.MapGroup("/Movies");

            MovieGroup.MapPost("/", CreateMovie);
            //MovieGroup.MapGet("/{id}", GetAMovie);
            MovieGroup.MapGet("/GetAllMovies", GetAllMovies);
            MovieGroup.MapPut("/UpdateMovie/{id}", UpdateAMovie);
            MovieGroup.MapDelete("/DeleteMovie/{id}", DeleteAMovie);
        }

        private static async Task<IResult> CreateMovie(IMovie<Movie> repository, PostMovieDTO movieDTO)
        {
            try
            {
                Movie movie = new()
                {
                    Title = movieDTO.Title,
                    Rating = movieDTO.Rating,
                    Description = movieDTO.Dectription,
                    RuntimeMins = movieDTO.RuntimeMins,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };

                var entity = await repository.CreateEntity(movie);

                Screening screening = new()
                {
                    MovieId = entity.Id,
                    Capacity = movieDTO.Screening.capacity,
                    ScreenNumber = movieDTO.Screening.screenNumber,
                    StartsAt = movieDTO.Screening.startsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                var screeningEntity = await repository.CreateEntityScreening(screening);

                //movie.screenings.add(new screening() 
                //{ 
                //    movie = movie,
                //    capacity = moviedto.screening.capacity,
                //    screennumber = moviedto.screening.screennumber,
                //    startsat = moviedto.screening.startsat
                //});


                Payload<Movie> payload = new();

                if (!(movieDTO == default(PostMovieDTO)))
                {
                    payload.load = movie;
                    payload.Status = "Success";
                }
                else
                {
                    payload.load = movie;
                }


                return TypedResults.Created("Created",movie);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
            
        }

        //private static async Task<IResult> GetAMovie(IMovie<Movie> Repository, int id)
        //{
            
        //}

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task DeleteAMovie(HttpContext context)
        {
            throw new NotImplementedException();


        }

        private static async Task UpdateAMovie(HttpContext context)
        {
            throw new NotImplementedException();
        }

        private static async Task GetAllMovies(HttpContext context)
        {
            throw new NotImplementedException();
        }

        //private static async Task CreateMovie(IMovie<Movie> repository, PostMovieDTO movieDTO)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }
}
