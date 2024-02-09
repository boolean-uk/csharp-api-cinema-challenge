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
            //movieGroup.MapGet("", GetAllMovies);
            //movieGroup.MapPut("{id}", UpdateMovie);
            //movieGroup.MapDelete("{id}", DeleteMovie);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
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

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]

        public static async Task<IResult> GetAllCustomers(IRepository<Customer> customerRepo)
        {
            var result = await customerRepo.GetAll();
            Payload<IEnumerable<Customer>> payload = new Payload<IEnumerable<Customer>>();
            payload.data = result;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public static async Task<IResult> UpdateCustomer(IRepository<Customer> customerRepo, int id, PutCustomer model)
        {
            var entity = await customerRepo.GetById(id);
            if (entity == null)
            {
                return TypedResults.NotFound();
            }
            entity.Name = model.Name;
            entity.Phone = model.Phone;
            var result = await customerRepo.Update(entity);

            return TypedResults.Ok(result);


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

