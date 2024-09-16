using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.Responses;
using api_cinema_challenge.DTO.ViewModel;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            // Customers
            cinema.MapPost("/customers", CreateCustomer);
            cinema.MapGet("/customers", GetCustomers);
            cinema.MapPut("/customers/{id}", UpdateCustomerById);
            cinema.MapDelete("/customers/{id}", DeleteCustomerById);

            // Movies
            cinema.MapPost("/movies", CreateMovie);
            cinema.MapGet("/movies", GetMovies);
            cinema.MapPut("/movies/{id}", UpdateMovieById);
            cinema.MapDelete("/movies/{id}", DeleteMovieById);

            // Screenings
            cinema.MapPost("/movies/{id}/screenings", CreateScreening);
            cinema.MapGet("/movies/{id}/screenings", GetScreenings);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostPutModel model)
        {
            try
            {
                Customer newCustomer = new Customer() 
                {
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                Payload<Customer> payload = new Payload<Customer>()
                {
                    Data = newCustomer
                };

                var creatingCustomer = await repository.CreateCustomer(payload.Data);
                var createdCustomer = await repository.GetCustomerById(creatingCustomer.Id);

                CustomerDTO customerDTO = new CustomerDTO() 
                {
                    Id = createdCustomer.Id,
                    Name = createdCustomer.Name,
                    Email = createdCustomer.Email,
                    Phone = createdCustomer.Phone,
                    CreatedAt = createdCustomer.CreatedAt,
                    UpdatedAt = createdCustomer.UpdatedAt
                };

                return TypedResults.Ok(customerDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            try 
            {
                GetAllResponse<CustomerDTO> response = new GetAllResponse<CustomerDTO>();
                var customers = await repository.GetAllCustomers();

                foreach (Customer customer in customers) 
                {
                    CustomerDTO customerDTO = new CustomerDTO() 
                    {
                        Id = customer.Id,
                        Name = customer.Name,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        CreatedAt = customer.CreatedAt,
                        UpdatedAt = customer.UpdatedAt
                    };

                    response.ResponseData.Add(customerDTO);
                }

                return TypedResults.Ok(response.ResponseData);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomerById(IRepository repository, CustomerPostPutModel model, int id)
        {
            try
            {
                var target = await repository.GetCustomerById(id);

                target.Name = model.Name;
                target.Email = model.Email;
                target.Phone = model.Phone;
                target.UpdatedAt = DateTime.UtcNow;

                Payload<Customer> payload = new Payload<Customer>()
                {
                    Data = target
                };

                await repository.UpdateCustomer(payload.Data);

                CustomerDTO customerDTO = new CustomerDTO 
                {
                    Id = target.Id,
                    Name = target.Name,
                    Email = target.Email,
                    Phone = target.Phone,
                    CreatedAt = target.CreatedAt,
                    UpdatedAt = target.UpdatedAt
                };

                return TypedResults.Ok(customerDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomerById(IRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteCustomer(id);

                CustomerDTO customerDTO = new CustomerDTO() 
                {
                    Id = target.Id,
                    Name = target.Name,
                    Email = target.Email,
                    Phone = target.Phone,
                    CreatedAt = target.CreatedAt,
                    UpdatedAt = target.UpdatedAt
                };

                return TypedResults.Ok(customerDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostPutModel model)
        {
            try
            {
                Movie newMovie = new Movie()
                {
                    Title = model.Title,
                    Rating = model.Rating,
                    Description = model.Description,
                    RuntimeMins = model.RuntimeMins,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };

                Payload<Movie> payload = new Payload<Movie>()
                {
                    Data = newMovie
                };

                var creatingMovie = await repository.CreateMovie(payload.Data);
                var createdMovie = await repository.GetMovieById(creatingMovie.Id);

                MovieDTO movieDTO = new MovieDTO()
                {
                    Id = createdMovie.Id,
                    Title = createdMovie.Title,
                    Rating = createdMovie.Rating,
                    Description = createdMovie.Description,
                    RuntimeMins = createdMovie.RuntimeMins,
                    CreatedAt = createdMovie.CreatedAt,
                    UpdatedAt = createdMovie.UpdatedAt
                };

                return TypedResults.Ok(movieDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            try
            {
                GetAllResponse<MovieDTO> response = new GetAllResponse<MovieDTO>();
                var movies = await repository.GetAllMovies();

                foreach (Movie movie in movies)
                {
                    MovieDTO movieDTO = new MovieDTO()
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Rating = movie.Rating,
                        Description = movie.Description,
                        RuntimeMins = movie.RuntimeMins,
                        CreatedAt = movie.CreatedAt,
                        UpdatedAt = movie.UpdatedAt    
                    };

                    response.ResponseData.Add(movieDTO);
                }

                return TypedResults.Ok(response.ResponseData);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovieById(IRepository repository, MoviePostPutModel model, int id)
        {
            try
            {
                var target = await repository.GetMovieById(id);

                target.Title = model.Title;
                target.Rating = model.Rating;
                target.Description = model.Description;
                target.RuntimeMins = model.RuntimeMins;
                target.UpdatedAt = DateTime.UtcNow;

                Payload<Movie> payload = new Payload<Movie>()
                {
                    Data = target
                };

                await repository.UpdateMovie(payload.Data);

                MovieDTO movieDTO = new MovieDTO
                {
                    Id = target.Id,
                    Title = target.Title,
                    Rating = target.Rating,
                    Description = target.Description,
                    RuntimeMins = target.RuntimeMins,
                    CreatedAt = target.CreatedAt,
                    UpdatedAt = target.UpdatedAt
                };

                return TypedResults.Ok(movieDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovieById(IRepository repository, int id)
        {
            try
            {
                var target = await repository.DeleteMovie(id);

                MovieDTO movieDTO = new MovieDTO()
                {
                    Id = target.Id,
                    Title = target.Title,
                    Rating = target.Rating,
                    Description = target.Description,
                    RuntimeMins = target.RuntimeMins,
                    CreatedAt = target.CreatedAt,
                    UpdatedAt = target.UpdatedAt
                };

                return TypedResults.Ok(movieDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPostModel model, int movieId)
        {
            try
            { 
                Screening newScreening = new Screening()
                {
                    ScreenNumber = model.ScreenNumber,
                    Capacity = model.Capacity,
                    StartsAt = model.StartsAt,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    MovieId = movieId
                };

                Payload<Screening> payload = new Payload<Screening>() 
                {
                    Data = newScreening
                };

                var creatingScreening = await repository.CreateScreening(payload.Data);
                var createdScreening = await repository.GetScreeningById(creatingScreening.Id);

                ScreeningDTO screeningDTO = new ScreeningDTO()
                {
                    Id = createdScreening.Id,
                    ScreenNumber = createdScreening.ScreenNumber,
                    Capacity = createdScreening.Capacity,
                    StartsAt = createdScreening.StartsAt,
                    CreatedAt = createdScreening.CreatedAt,
                    UpdatedAt = createdScreening.UpdatedAt
                };

                return TypedResults.Ok(screeningDTO);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {
            try
            {
                GetAllResponse<ScreeningDTO> response = new GetAllResponse<ScreeningDTO>();
                var screenings = await repository.GetAllScreenings(movieId);

                foreach (Screening screening in screenings)
                {
                    ScreeningDTO screeningDTO = new ScreeningDTO()
                    {
                        Id = screening.Id,
                        ScreenNumber = screening.ScreenNumber,
                        Capacity = screening.Capacity,
                        StartsAt = screening.StartsAt,
                        CreatedAt = screening.CreatedAt,
                        UpdatedAt = screening.UpdatedAt,
                    };

                    response.ResponseData.Add(screeningDTO);
                }

                return TypedResults.Ok(response.ResponseData);
            }
            catch (KeyNotFoundException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
