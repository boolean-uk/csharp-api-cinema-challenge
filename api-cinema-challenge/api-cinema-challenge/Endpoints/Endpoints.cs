using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;
using Npgsql.Replication;

namespace api_cinema_challenge.Endpoints
{
    public static class Endpoints
    {
        public static void ConfigureEndpoints(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("Cinema");

            //Customers
            cinemaGroup.MapGet("/Customers", GetCustomers);
            cinemaGroup.MapGet("/customers/{id}", GetACustomer);
            cinemaGroup.MapPost("/customers", CreateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            //Movies
            cinemaGroup.MapGet("/Movies", GetMovies);
            cinemaGroup.MapGet("/Movies/{id}", GetAMovie);
            cinemaGroup.MapPost("/Movies/", CreateMovie);
            cinemaGroup.MapDelete("/Movies/{id}", DeleteMovie);
            cinemaGroup.MapPut("/Movies/{id}", UpdateMovie);
            //Screening
            cinemaGroup.MapGet("/movies/{id}/screeings", GetScreenings);
            cinemaGroup.MapPost("/movies/{id}/screeings", CreateScreening);
            //Ticket
            cinemaGroup.MapGet("/customers/{customerId}/Screenings/{screeningId}", GetTickets);
            //cinemaGroup.MapPost("/customers/{customerId}/Screenings/{screeningId}", CreateTicket);
            cinemaGroup.MapPost("/customers/{customerId}/Screenings/{screeningId}", BookTicket);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            var result = await repository.Get();

            List<CustomerDTO> dtoCustomers = new List<CustomerDTO>();

            foreach (var customer in result)
            {
                CustomerDTO customerDTO = new CustomerDTO()
                {
                    Name = customer.Name,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt
                };
                dtoCustomers.Add(customerDTO);
            };
            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            payload.data = dtoCustomers;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetACustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.GetById(id);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = customerDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, Customer customer)
        {
            Customer createCustomer = new Customer()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var aCustomer = await repository.Insert(createCustomer);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = aCustomer.Name,
                Email = aCustomer.Email,
                PhoneNumber = aCustomer.PhoneNumber,
                CreatedAt = aCustomer.CreatedAt,
                UpdatedAt = aCustomer.UpdatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = customerDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            var customer = await repository.GetById(id);
            await repository.Delete(id);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };
            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = customerDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, Customer customer)
        {
            var aCustomer = await repository.GetById(id);

            aCustomer.Name = customer.Name;
            aCustomer.Email = customer.Email;
            aCustomer.PhoneNumber = customer.PhoneNumber;
            aCustomer.UpdatedAt = DateTime.UtcNow;

            await repository.Update(aCustomer);

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = customerDTO;
            return TypedResults.Ok(payload);
        }

        //Movies 

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var movies = await repository.Get();


            List<MovieDTO> dtoMovies = new List<MovieDTO>();

            foreach (var movie in movies)
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    Title = movie.Title,
                    Runtime = movie.Runtime,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,
                    Screenings = movie.Screenings.Where(s => s.MovieId == movie.Id).Select(s => new ScreeningDTO
                    {
                        Capacity = s.Capacity,
                        ScreenNumber = s.ScreenNumber,
                        startsAt = s.startsAt,
                        CreatedAt = s.CreatedAt,
                        UpdatedAt = s.UpdatedAt

                    }).ToList()
                };
                dtoMovies.Add(movieDTO);
            };

            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            payload.data = dtoMovies;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.GetById(id);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
                Screenings = movie.Screenings.Where(s => s.MovieId == movie.Id).Select(s => new ScreeningDTO
                {
                    Capacity = s.Capacity,
                    ScreenNumber = s.ScreenNumber,
                    startsAt = s.startsAt,
                    CreatedAt = s.CreatedAt,
                    UpdatedAt = s.UpdatedAt

                }).ToList()

            };
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = movieDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, Movie movie)
        {
            await repository.Insert(movie);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt

            };

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = movieDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            var movie = await repository.GetById(id);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt
            };
            await repository.Delete(id);

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = movieDTO;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, Movie movie)
        {
            var updatedMovie = await repository.GetById(id);

            updatedMovie.Title = movie.Title;
            updatedMovie.Runtime = movie.Runtime;
            updatedMovie.Rating = movie.Rating;
            updatedMovie.Description = movie.Description;
            updatedMovie.UpdatedAt = movie.UpdatedAt;

            await repository.Update(updatedMovie);

            MovieDTO movieDTO = new MovieDTO()
            {
                Title = movie.Title,
                Runtime = movie.Runtime,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,
            };

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = movieDTO;
            return TypedResults.Ok(payload);
        }

        //screenings 

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, IRepository<Movie> movieRepository, int id)
        {
            var movies = await movieRepository.GetById(id);
            var screenings = movies.Screenings.ToList();

            List<ScreeningDTO> result = new List<ScreeningDTO>();

            foreach (var screening in screenings)
            {
                ScreeningDTO screeningDTO = new ScreeningDTO()
                {
                    Capacity = screening.Capacity,
                    ScreenNumber = screening.ScreenNumber,
                    startsAt = screening.startsAt,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt

                };
                result.Add(screeningDTO);
            }
            //Payload<IEnumerable<ScreeningDTO>> paylaod = new Payload<IEnumerable<ScreeningDTO>>();
            DoublePayload<Movie, IEnumerable<ScreeningDTO>> paylaod = new DoublePayload<Movie, IEnumerable<ScreeningDTO>>();
            paylaod.dataOne = movies;
            paylaod.dataTwo = result;
            return TypedResults.Ok(paylaod);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, IRepository<Movie> movieRepository, int id, Screening screening)
        {   
            var movie = await movieRepository.GetById(id);

            Screening aScreening = new Screening()
            {
                Id = screening.Id,
                Capacity = screening.Capacity,
                Movie = movie,
                ScreenNumber = screening.ScreenNumber,
                startsAt = screening.startsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Insert(aScreening);

            ScreeningDTO screeningDTO = new ScreeningDTO()
            {
                Capacity = screening.Capacity,
                ScreenNumber = screening.ScreenNumber,
                startsAt = screening.startsAt,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
            payload.data = screeningDTO;
            return TypedResults.Ok(payload);
        }

        //Ticket

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, IRepository<Customer> customerRepository, int id)
        {
            var customer = await customerRepository.GetById(id);
            var tickets = customer.Tickets.ToList();
            

            List<TicketDTO> result = new List<TicketDTO>();
            foreach (var ticket in tickets)
            {
                TicketDTO ticketDTO = new TicketDTO()
                {
                    Id = ticket.Id,
                    SeatNumber = ticket.SeatNumber,
                    UpdatedAt = ticket.UpdatedAt,
                    CreatedAt = ticket.CreatedAt
                };
                result.Add(ticketDTO);
            }

            CustomerDTO customerDTO = new CustomerDTO()
            {
                Name = customer.Name,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            DoublePayload<CustomerDTO, IEnumerable<TicketDTO>> payload = new DoublePayload<CustomerDTO, IEnumerable<TicketDTO>>();
            payload.dataOne = customerDTO;
            payload.dataTwo = result;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, Ticket ticket)
        {
            await repository.Insert(ticket);

            TicketDTO ticketDTO = new TicketDTO()
            {
                Id = ticket.Id,
                SeatNumber = ticket.SeatNumber,
                UpdatedAt = ticket.UpdatedAt,
                CreatedAt = ticket.CreatedAt
            };

            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            payload.data = ticketDTO;
            return TypedResults.Ok(payload);
        } [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> BookTicket(IRepository<Ticket> repository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, int customerId, int screeningId, int numSeat)
        {

            Ticket ticket = new Ticket()
            {
                CustomerID = customerId,
                ScreeningId = screeningId,
                SeatNumber = numSeat,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            await repository.Insert(ticket);

            NumSeats seatNum = new NumSeats()
            {
                numSeats = ticket.SeatNumber

            };

            Payload<NumSeats> payload = new Payload<NumSeats>();
            payload.data = seatNum;
            return TypedResults.Ok(payload);
        }
    }
}
