using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MovieEndpoint
    {
        public static void ConfigureMovieEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movie/");

            movieGroup.MapPost("", CreateMovie);
            movieGroup.MapGet("", GetAllMovies);
            movieGroup.MapPut("{id}", UpdateMovie);
            //movieGroup.MapDelete("{id}", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> movieRepo, PostMovie model)
        {
            var entity = new Movie() 
            { 
                Title = model.Title, 
                Rating = model.Rating, 
                Description=model.Description,
                RuntimeMins = model.RuntimeMins,
            };
            var create = await movieRepo.Create(entity);

            var result = new MovieDTO()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = model.RuntimeMins
            };

            return TypedResults.Created($"{entity.Id}",result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAllMovies(IRepository<Movie> movieRepo)
        {
            var result = await movieRepo.GetAll();
            Payload<IEnumerable<Movie>> payload = new Payload<IEnumerable<Movie>>();
            payload.data = result;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> UpdateMovie(IRepository<Movie> movieRepo, int id, PutMovie model)
        {
            var entity = await movieRepo.GetById(id);
            if (entity == null)
            {
                return TypedResults.NotFound();
            }
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Rating = model.Rating;
            entity.RuntimeMins = (int)model.RuntimeMins;
            var update = new MovieDTO()
            {
                Title = model.Title,
                Rating = model.Rating,
                Description = model.Description,
                RuntimeMins = (int)model.RuntimeMins
            };
            var result = await movieRepo.Update(entity);

            return TypedResults.Created("",update);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> customerRepo, int id)
        {
            var result = await customerRepo.Delete(id);
            if (result == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(result);
        }

    }
}

