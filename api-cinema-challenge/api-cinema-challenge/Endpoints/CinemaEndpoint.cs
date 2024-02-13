using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOs;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/customers", GetAllCustomers);
            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

            cinemaGroup.MapGet("/movies", GetAllMovies);
            cinemaGroup.MapPost("/movies", CreateMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

            cinemaGroup.MapGet("/screenings", GetAllScreenings);
            cinemaGroup.MapPost("/screenings", CreateScreening);

            cinemaGroup.MapGet("/ticket", GetAllTickets);
            cinemaGroup.MapPost("/ticket", CreateTicket);
        }

        //---------------------------- Customer -------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllCustomers(IRepository<Customer> repository)
        {
            var customers = await repository.GetAll();
            var response = new ApiResponse<IEnumerable<Customer>>
            {
                Status = "success",
                Data = customers
            };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerDTO customerDTO)
        {
            var customer = new Customer
            {
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Phone = customerDTO.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdCustomer = await repository.Add(customer);
            var response = new ApiResponse<Customer>
            {
                Status = "success",
                Data = createdCustomer
            };
            //return TypedResults.Created($"Customer {customer.Name} with id {customer.Id} has been added.");
            return TypedResults.Created($"/{customer.Id}", response); 
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, CustomerDTO customerDTO)
        {
            var customer = await repository.Get(id);
            if (customer == null)
                return TypedResults.NotFound($"Customer with id {id} doesn't exist");

            customer.Name = customerDTO.Name;
            customer.Email = customerDTO.Email;
            customer.Phone = customerDTO.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            await repository.Update(customer);
            var response = new ApiResponse<Customer>
            {
                Status = "success",
                Data = customer
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.Get(id);
            if (customer == null)
                return TypedResults.NotFound($"Customer with id {id} doesn't exist");

            await repository.Delete(id);
            var response = new ApiResponse<Customer>
            {
                Status = "success",
                Data = customer
            };
            return TypedResults.Ok(response);
        }

        //------------------------------ Movie ------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IRepository<Movie> repository)
        {
            var movies = await repository.GetAll();
            var response = new ApiResponse<IEnumerable<Movie>>
            {
                Status = "success",
                Data = movies
            };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, MovieDTO movieDTO)
        {
            var movie = new Movie
            {
                Title = movieDTO.Title,
                Rating = movieDTO.Rating,
                Description = movieDTO.Description,
                RuntimeMins = movieDTO.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdMovie = await repository.Add(movie);
            var response = new ApiResponse<Movie>
            {
                Status = "success",
                Data = createdMovie
            };
            return TypedResults.Created($"/{movie.Id}", response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, MovieDTO movieDTO)
        {
            var movie = await repository.Get(id);
            if (movie == null)
                return TypedResults.NotFound($"Movie with id {id} doesn't exist");

            movie.Title = movieDTO.Title;
            movie.Rating = movieDTO.Rating;
            movie.Description = movieDTO.Description;
            movie.RuntimeMins = movieDTO.RuntimeMins;
            movie.UpdatedAt = DateTime.UtcNow;

            await repository.Update(movie);
            var response = new ApiResponse<Movie>
            {
                Status = "success",
                Data = movie
            };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.Get(id);
            if (movie == null)
                return TypedResults.NotFound($"Movie with id {id} doesn't exist");

            await repository.Delete(id);
            var response = new ApiResponse<Movie>
            {
                Status = "success",
                Data = movie
            };
            return TypedResults.Ok(response);
        }

        //----------------------- Screening ----------------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllScreenings(IRepository<Screening> repository)
        {
            var screenings = await repository.GetAll();
            var response = new ApiResponse<IEnumerable<Screening>>
            {
                Status = "success",
                Data = screenings
            };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, ScreeningDTO screeningDTO)
        {
            var screening = new Screening
            {
                ScreenNumber = screeningDTO.ScreenNumber,
                Capacity = screeningDTO.Capacity,
                StartsAt = screeningDTO.StartsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdScreening = await repository.Add(screening);
            var response = new ApiResponse<Screening>
            {
                Status = "success",
                Data = createdScreening
            };
            return TypedResults.Created($"/{screening.Id}", response);
        }

        //---------------------------- Ticket ---------------------------------
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllTickets(IRepository<Ticket> repository)
        {
            var tickets = await repository.GetAll();
            var response = new ApiResponse<IEnumerable<Ticket>>
            {
                Status = "success",
                Data = tickets
            };
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, TicketDTO ticketDTO)
        {
            var ticket = new Ticket
            {
                NumSeats = ticketDTO.NumSeats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            var createdTicket = await repository.Add(ticket);
            var response = new ApiResponse<Ticket>
            {
                Status = "success",
                Data = createdTicket
            };
            return TypedResults.Created($"/{ticket.Id}", response);
        }
    }
}
