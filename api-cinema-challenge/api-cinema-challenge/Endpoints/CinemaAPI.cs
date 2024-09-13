using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.GetResponses;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaAPI
    {
        public static void ConfigureCinemaEnpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            cinema.MapGet("/customers", GetCustomers);
            cinema.MapGet("/movies", GetMovies);
            cinema.MapGet("/movies/{id}/screenings", GetScreenings);
            cinema.MapPost("/customers", CreateCustomer);
            cinema.MapPost("/movies", CreateMovie);
            cinema.MapPost("/movies/{id}/screenings", CreateScreening);
            cinema.MapPut("/customers/{id}", UpdateCustomer);
            cinema.MapPut("/movies/ {id}", UpdateMovie);
            cinema.MapDelete("/customers/{id}", DeleteCustomer);
            cinema.MapDelete("/movies/{id}", DeleteMovie);
        }


        //getters
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            GetCustomerResponse response = new GetCustomerResponse();
            var results = await repository.GetAllCustomers();

            foreach (Customer result in results)
            {
                CustomerDTO dto = new CustomerDTO() { 
                    Id = result.Id,
                    Name = result.Name,
                    Email = result.Email,
                    Phone = result.Phone,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Customers.Add(dto);
            }
            return TypedResults.Ok(response.Customers);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            GetMovieResponse response = new GetMovieResponse();
            var results = await repository.GetAllMovies();

            foreach (Movie result in results)
            {
                MovieDTO dto = new MovieDTO()
                {
                    Id = result.Id,
                    Title = result.Title,
                    Description = result.Description,
                    RuntimeMins = result.RuntimeMins,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Movies.Add(dto);
            }
            return TypedResults.Ok(response.Movies);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {

            GetScreeningResponse response = new GetScreeningResponse();
            var results = await repository.GetAllCScreenings(movieId);

            foreach (Screening result in results)
            {
                ScreeningDTO dto = new ScreeningDTO()
                {
                    Id = result.Id,
                    ScreenNumber = result.ScreenNumber,
                    Capacity = result.Capacity,
                    StartsAt = result.StartsAt,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Screenings.Add(dto);
            }
            return TypedResults.Ok(response.Screenings);
        }

        //creates
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository)
        {
            return null;
        }  
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository)
        {
            return null;
        } 
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository repository)
        {
            return null;
        }  
        
        //updates
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository)
        {
            return null;
        } 
        
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository)
        {
            return null;
        }


        //deletes
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IEnumerable<IResult>> DeleteCustomer(IRepository repository)
        {

            return null;
        }
        
        
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IEnumerable<IResult>> DeleteMovie(IRepository repository)
        {

            return null;
        }

    }
}
