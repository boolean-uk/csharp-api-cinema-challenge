
using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.api_cinema_challenge.DTO;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.Endpoints
{
    public static class MovieEndpoint
    {

        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("Cinema");
            cinema.MapGet("/customers", GetCustomers);
            cinema.MapPost("/customers", AddCustomers);
            cinema.MapPut("/customers", UpdateCustomers);
            cinema.MapDelete("/customers", DeleteCustomers);
            //movies
            cinema.MapGet("/movies", GetMovies);
            cinema.MapPost("/movies", AddMovie);
            cinema.MapPut("/movies", UpdateMovie);
            cinema.MapDelete("/movies", DeleteMovie);

            //screenings
            cinema.MapGet("/Screening", GetScreenings);
            cinema.MapPost("/Screening", CreateScreening);
        }

        private static async Task<IResult> CreateScreening(IRepository repository, int movieId, int screenNumber, int capacity, DateTime startsAt)
        {
            var screening = await repository.CreateScreening(movieId, screenNumber, capacity, startsAt);

            if (screening == null)
            {
                return Results.BadRequest("Failed to create screening. Check movie ID or other input values.");
            }

            var screeningDTO = new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt,
                MovieId = screening.MovieId,
                MovieTitle = screening.Movie.Title
            };

            return TypedResults.Ok(screeningDTO);
        }

        private static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            var screenings = await repository.GetScreenings(movieId);

            if (screenings == null || !screenings.Any())
            {
                return Results.NotFound("No screenings found for the given movie.");
            }

            var screeningDTOs = screenings.Select(s => new ScreeningDTO
            {
                Id = s.Id,
                ScreenNumber = s.ScreenNumber,
                Capacity = s.Capacity,
                StartsAt = s.StartsAt,
                CreatedAt = s.CreatedAt,
                UpdatedAt = s.UpdatedAt,
                MovieId = s.MovieId,
                MovieTitle = s.Movie.Title
            }).ToList();

            return TypedResults.Ok(screeningDTOs);
        }


        private static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            var movie = await repository.DeleteMovie(id);
            if (movie == null)
            {
                return Results.NotFound(); // Return 404 if movie doesn't exist
            }

            // You can return a confirmation message or a DTO if needed
            return Results.Ok(new { Message = "Movie deleted successfully" });
        }

        private static async Task<IResult> UpdateMovie(IRepository repository, int id, string title, string rating, string description, int runtimeMins)
        {
            var movie = await repository.UpdateMovie(id, title, rating, description, runtimeMins);
            if (movie == null)
            {
                return Results.NotFound(); // Return 404 if movie doesn't exist
            }

            MovieDTO dto = new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            };

            return Results.Ok(dto); // Return updated movie details
        }

        private static async Task<IResult> AddMovie(IRepository repository, string title, string rating, string description, int runtimeMins)
        {
            var movie = await repository.AddMovie(title, rating, description, runtimeMins);
            if (movie == null)
            {
                return Results.BadRequest("Movie could not be added"); // Return a 400 Bad Request if movie can't be added
            }

            MovieDTO dto = new MovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            };

            return Results.Ok(dto); // Return the added movie details
        }

        private static async Task<IResult> GetMovies(IRepository repository)
        {
            var movies = await repository.GetMovies();
            var movieDTO = movies.Select(m => new MovieDTO
            {

                Id = m.Id,
                Title = m.Title,
                Rating = m.Rating,
                Description = m.Description,
                RuntimeMins=m.RuntimeMins,
                CreatedAt = m.CreatedAt,
                UpdatedAt = m.UpdatedAt,


            }).ToList();

            return TypedResults.Ok(movieDTO);

        }

        private static async Task<IResult> DeleteCustomers(IRepository repository,int id)
        {
            var customer = await repository.DeleteCustomer(id);
            CustomerDTO dto = new CustomerDTO();
            if (customer == null)
            {
                return Results.NotFound();
            }
            dto.Id = customer.Id;
            dto.Name = customer.Name;
            dto.Email = customer.Email;
            dto.Phone = customer.Phone;
            dto.CreatedAt = customer.CreatedAt;
            dto.UpdatedAt = customer.UpdatedAt;


            return TypedResults.Ok(dto);



        }

        private static async Task<IResult> UpdateCustomers(IRepository repository,int id, string name, string email, string phone )
        {
            var customer= await repository.UpdateCustomer(id, name, email, phone);
            CustomerDTO dto = new CustomerDTO();
            if (customer == null)
            {
                return Results.NotFound();
            }
            dto.Id = customer.Id;
            dto.Name = customer.Name;
            dto.Email = customer.Email;
            dto.Phone = customer.Phone;
            dto.CreatedAt = customer.CreatedAt;
            dto.UpdatedAt = customer.UpdatedAt;


            return TypedResults.Ok(dto);


        }

        private static async Task<IResult> AddCustomers(IRepository repository, string name, string email,string phone)
        {
            var customer = await repository.AddCustomer(name, email, phone);
            if (customer == null)
            {
                return Results.NotFound();
            }
            CustomerDTO dto = new CustomerDTO();
            dto.Id = customer.Id;
            dto.Name= customer.Name;
            dto.Email= customer.Email;
            dto.Phone= customer.Phone;
            dto.CreatedAt = customer.CreatedAt;
            dto.UpdatedAt = customer.UpdatedAt;
            return TypedResults.Ok(dto);
        }

        private static async Task<IResult> GetCustomers(IRepository repository)
        {
            var customers = await repository.GetCustomers();
            var customerDTO = customers.Select(c => new CustomerDTO
            {

                Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt,


            }).ToList();

            return TypedResults.Ok(customerDTO);
            
        }
    }
}
