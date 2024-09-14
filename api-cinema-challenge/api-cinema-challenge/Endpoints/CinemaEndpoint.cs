using api_cinema_challenge.DTO.ViewModel;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            // Customers
            cinema.MapPost("/customers/create", CreateCustomer);
            cinema.MapGet("/customers", GetCustomers);
            cinema.MapPut("/customers/update/{id}", UpdateCustomerById);
            cinema.MapDelete("/customers/delete/{id}", DeleteCustomerById);

            // Movies
            cinema.MapPost("/movies/create", CreateMovie);
            cinema.MapGet("/movies", GetAllMovies);
            cinema.MapPut("/movies/update/{id}", UpdateMovieById);
            cinema.MapDelete("/movies/delete/{id}", DeleteMovieById);

            // Screenings
            cinema.MapPost("/screenings/create", CreateScreening);
            cinema.MapGet("/screenings", GetScreenings);
        }

        public static async Task<IResult> GetScreenings(IRepository repository)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPostModel model)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> DeleteMovieById(IRepository repository, int id)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> UpdateMovieById(IRepository repository, int id)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel model)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> DeleteCustomerById(IRepository repository, int id)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> UpdateCustomerById(IRepository repository, int id)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel model)
        {
            throw new NotImplementedException();
        }

        public static async Task<IResult> GetAllMovies(IRepository repository)
        {
            throw new NotImplementedException();
        }
    }
}
