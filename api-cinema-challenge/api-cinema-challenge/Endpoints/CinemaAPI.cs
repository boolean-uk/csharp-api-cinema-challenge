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
        public static async Task<IEnumerable<IResult>> GetCustomers(IRepository repository)
        {

            return null;
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IEnumerable<IResult>> GetMovies(IRepository repository)
        {

            return null;
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IEnumerable<IResult>> GetScreenings(IRepository repository)
        {

            return null;
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
