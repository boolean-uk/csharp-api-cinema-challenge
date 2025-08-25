using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System.Xml.Linq;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers{id}", DeleteCustomer);
            cinemaGroup.MapGet("/customers", GetCustomers);
            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies{id}", DeleteMovie);
            cinemaGroup.MapGet("/movies", GetMovies);
            cinemaGroup.MapGet("/movies/{id}", GetMovieById);
            cinemaGroup.MapPost("/screenings", CreateScreening);
            cinemaGroup.MapGet("/screenings", GetScreenings);
            cinemaGroup.MapPost("/tickets", CreateTicket);
            cinemaGroup.MapGet("/tickets", GetTickets);
        }

        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            List<MovieDTO> movies = new List<MovieDTO>();
            var allMovies = await repository.GetAll();

            foreach (var movie in allMovies)
            {
                movies.Add(new MovieDTO { Title = movie.Title, Description = movie.Description, Rating = movie.Rating, 
                    RuntimeMins = movie.RuntimeMins, CreatedAt = movie.CreatedAt, UpdatedAt = movie.UpdatedAt});
            }

            return TypedResults.Ok(movies);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, IRepository<Screening> screenRepo, IRepository<Customer> customerRepo)
        {
            List<TicketDTO> tickets = new List<TicketDTO>();
            var allTickets = await repository.GetAll();

            foreach (var ticket in allTickets)
            {
                Screening screening = await screenRepo.GetByIdWithIncludes(ticket => ticket.Movie, ticket.ScreeningId);
                Customer cust = await customerRepo.GetById(ticket.CustomerId);
                ScreeningDTO screendto = new ScreeningDTO
                {
                    MovieId = screening.MovieId,
                    ScreenNumber = screening.ScreenNumber,
                    Capacity = screening.Capacity,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt,
                    StartsAt = screening.StartsAt,
                    Movie = new MovieDTO
                    {
                        Title = screening.Movie.Title,
                        Description = screening.Movie.Description,
                        Rating = screening.Movie.Rating,
                        RuntimeMins = screening.Movie.RuntimeMins,
                        CreatedAt = screening.Movie.CreatedAt,
                        UpdatedAt = screening.Movie.UpdatedAt
                    }
                };
                CustomerDTO customerdto = new CustomerDTO {
                    Name = cust.Name, 
                    Email = cust.Email, 
                    Phone = cust.Phone
                };

                tickets.Add(new TicketDTO
                {
                    NumSeats = ticket.NumSeats,
                    Screening = screendto,
                    Customer = customerdto,
                    CreatedAt = ticket.CreatedAt,
                    UpdatedAt = ticket.UpdatedAt
                });
            }

            return TypedResults.Ok(tickets);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            var customers = await repository.GetAll();

            foreach (var customer in customers)
            {
                customerDTOs.Add(new CustomerDTO
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone
                });
            }

            return TypedResults.Ok(customerDTOs);
        }
        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerDTO cust)
        {
            Customer newcust = new Customer { Name = cust.Name, Email = cust.Email, Phone = cust.Phone };
            newcust = await repository.Create(newcust);
            return TypedResults.Created("Created new customer", new CustomerDTO { Name = newcust.Name, Email = newcust.Email, Phone = newcust.Phone });
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, TicketPost ticket)
        {
            Ticket newticket = new Ticket { NumSeats = ticket.NumSeats, CustomerId = ticket.CustomerId, ScreeningId = ticket.ScreeningId,
                CreatedAt = DateTime.Now.ToUniversalTime(), UpdatedAt = DateTime.Now.ToUniversalTime() };
            newticket = await repository.Create(newticket);
            return TypedResults.Created("Success", new {
                NumSeats = newticket.NumSeats,
                CreatedAt = newticket.CreatedAt,
                UpdatedAt = newticket.UpdatedAt
            });
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, ScreeningPost screen)
        {
            Screening newscreen = new Screening { MovieId = screen.MovieId, ScreenNumber = screen.ScreenNumber, Capacity = screen.Capacity, CreatedAt = screen.CreatedAt, UpdatedAt = screen.UpdatedAt, StartsAt = screen.StartsAt };
            newscreen = await repository.Create(newscreen);
            return TypedResults.Created("Created new screening", new ScreeningDTO { MovieId = newscreen.MovieId, ScreenNumber = newscreen.ScreenNumber, Capacity = newscreen.Capacity, CreatedAt = newscreen.CreatedAt, UpdatedAt = newscreen.UpdatedAt, StartsAt = newscreen.StartsAt });
        }
        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository)
        {
            List<ScreeningDTO> screeningDTOs = new List<ScreeningDTO>();
            var screenings = await repository.GetAllWithIncludes(s => s.Movie);

            foreach (var screening in screenings)
            {
                screeningDTOs.Add(new ScreeningDTO
                {
                    MovieId = screening.MovieId,
                    ScreenNumber = screening.ScreenNumber,
                    Capacity = screening.Capacity,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt,
                    StartsAt = screening.StartsAt,
                    Movie = new MovieDTO 
                    {
                        Title = screening.Movie.Title,
                        Description = screening.Movie.Description,
                        Rating = screening.Movie.Rating,
                        RuntimeMins = screening.Movie.RuntimeMins,
                        CreatedAt = screening.Movie.CreatedAt,
                        UpdatedAt = screening.Movie.UpdatedAt
                    }
                });
            }

            return TypedResults.Ok(screeningDTOs);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieDTO mov)
        {
            Movie newmov = new Movie
            {
                Title = mov.Title,
                Description = mov.Description,
                Rating = mov.Rating,
                RuntimeMins = mov.RuntimeMins,
                CreatedAt = mov.CreatedAt,
                UpdatedAt = mov.UpdatedAt
            };
            newmov = await repository.Create(newmov);
            return TypedResults.Created("Created new customer", new MovieDTO
            {
                Title = mov.Title,
                Description = mov.Description,
                Rating = mov.Rating,
                RuntimeMins = mov.RuntimeMins,
                CreatedAt = mov.CreatedAt,
                UpdatedAt = mov.UpdatedAt
            });
        }
        [Authorize(Roles = "User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovieById(IRepository<Movie> repository, int id)
        {
            Movie mov = await repository.GetById(id);
            MovieDTO movdto = new MovieDTO
            {
                Title = mov.Title,
                Description = mov.Description,
                Rating = mov.Rating,
                RuntimeMins = mov.RuntimeMins,
                CreatedAt = mov.CreatedAt,
                UpdatedAt = mov.UpdatedAt
            };
            return TypedResults.Ok(movdto);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            Movie mov = await repository.Delete(id);
            MovieDTO movdto = new MovieDTO
            {
                Title = mov.Title,
                Description = mov.Description,
                Rating = mov.Rating,
                RuntimeMins = mov.RuntimeMins,
                CreatedAt = mov.CreatedAt,
                UpdatedAt = mov.UpdatedAt
            };
            return TypedResults.Ok(movdto);
        }
        [Authorize(Roles = "Admin")]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Customer cust = await repository.Delete(id);
            CustomerDTO custdto = new CustomerDTO
            {
                Name = cust.Name,
                Email = cust.Email,
                Phone = cust.Phone
            };
            return TypedResults.Ok(custdto);
        }

        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> Delete(IRepository<Movie> repository, int id)
        {
            Movie mov = await repository.Delete(id);
            MovieDTO movdto = new MovieDTO
            {
                Title = mov.Title,
                Description = mov.Description,
                Rating = mov.Rating,
                RuntimeMins = mov.RuntimeMins,
                CreatedAt = mov.CreatedAt,
                UpdatedAt = mov.UpdatedAt
            };
            return TypedResults.Ok(movdto);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, CustomerDTO custdto, int id)
        {
            Customer cust = new Customer {Name = custdto.Name, Email = custdto.Email, Phone = custdto.Phone};
            var updatedCust = await repository.Update(cust, id);
            CustomerDTO returnedCust = new CustomerDTO { Name = updatedCust.Name, Email = updatedCust.Email, Phone = updatedCust.Phone };
            return TypedResults.Ok(returnedCust);
        }
        [Authorize(Roles = "Admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, MovieDTO movdto, int id)
        {
            Movie mov = new Movie
            {
                Title = movdto.Title,
                Description = movdto.Description,
                Rating = movdto.Rating,
                RuntimeMins = movdto.RuntimeMins,
                CreatedAt = movdto.CreatedAt,
                UpdatedAt = DateTime.Now
            };
            var updatedMov = await repository.Update(mov, id);
            MovieDTO returnedMov = new MovieDTO   
            {
                Title = updatedMov.Title,
                Description = updatedMov.Description,
                Rating = updatedMov.Rating,
                RuntimeMins = updatedMov.RuntimeMins,
                CreatedAt = updatedMov.CreatedAt,
                UpdatedAt = updatedMov.UpdatedAt
            };

            return TypedResults.Ok(returnedMov);
        }
    }
}
