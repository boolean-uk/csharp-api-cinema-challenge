using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payload;
using api_cinema_challenge.Posts___Puts;
using api_cinema_challenge.Repo;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureEndpoint(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema/");

            cinemaGroup.MapGet("customers/", GetCustomers);
            cinemaGroup.MapPost("customers/", CreateCustomer);
            cinemaGroup.MapPut("customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("customer/{id}", DeleteCustomer);

            cinemaGroup.MapGet("movies/", GetMovies);
            cinemaGroup.MapPost("movies/", CreateMovie);
            cinemaGroup.MapPut("movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("movies/{id}", DeleteMovie);

            cinemaGroup.MapGet("movies/{id}/screenings/", GetScreenings);
            cinemaGroup.MapPost("movies/{id}/screenings/", CreateScreening);

            cinemaGroup.MapGet("customers/{customerId}/screenings/{screeningId}/", GetTickets);
            cinemaGroup.MapPost("customers/{customerId}/screenings/{screeningId}/", CreateTicket);
        }

        #region Customers
        //CUSTOMER METHODS HERE
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepo<Customer> repo)
        {
            var result = await repo.GetAll();
            List<CustomerDTO> customers = new List<CustomerDTO>();

            foreach (var customer in result)
            {
                CustomerDTO customerDTO = new CustomerDTO()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    createdAt = customer.createdAt,
                    updatedAt = customer.updatedAt
                };
                customers.Add(customerDTO);
            }

            Payload<IEnumerable<CustomerDTO>> payload = new Payload<IEnumerable<CustomerDTO>>();
            payload.data = customers;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepo<Customer> repo, CustomerPostPut customerNew)
        {
            var entity = new Customer() { Name = customerNew.name, Phone = customerNew.phone, Email = customerNew.email };
            var create = await repo.Create(entity);

            var result = new CustomerDTO()
            {
                Id = create.Id,
                Name = create.Name,
                Phone = create.Phone,
                Email = create.Email,
                createdAt = create.createdAt,
                updatedAt = create.updatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = result;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(IRepo<Customer> repo, int id, CustomerPostPut changeCustomer)
        {

            var entity = await repo.Get(id);
            if(entity == null)
            {
                return TypedResults.NotFound();
            }

            entity.Name = changeCustomer.name;
            entity.Phone = changeCustomer.phone;
            entity.Email = changeCustomer.email;
            var result = await repo.Update(entity); 
            
            var dto = new CustomerDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Phone = result.Phone,
                Email = result.Email,
                createdAt = result.createdAt,
                updatedAt = result.updatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepo<Customer> repo, int id)
        {
            var entity = await repo.Delete(id);
            if(entity == null)
            {
                return TypedResults.NotFound();
            }

            var dto = new CustomerDTO()
            {
                Id = entity.Id,
                Name = entity.Name,
                Phone = entity.Phone,
                Email = entity.Email,
                createdAt = entity.createdAt,
                updatedAt = entity.updatedAt
            };

            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);

        }

        #endregion

        #region Movies
        //MOVIE METHODS HERE

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies (IRepo<Movie> repo)
        {
            var result = await repo.GetAll();
            List<MovieDTO> movies = new List<MovieDTO>();

            foreach (var movie in result)
            {
                MovieDTO movieDTO = new MovieDTO()
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Rating = movie.Rating,
                    Description = movie.Description,
                    RuntimeMins = movie.RuntimeMins,
                    createdAt = movie.createdAt,
                    updatedAt = movie.updatedAt
                };
                movies.Add(movieDTO);
            }

            Payload<IEnumerable<MovieDTO>> payload = new Payload<IEnumerable<MovieDTO>>();
            payload.data = movies;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepo<Movie> repo, MoviePostPut newMovie)
        {
            var thisMovie = new Movie() 
            {
                Title = newMovie.Title,
                Rating = newMovie.Rating,
                Description = newMovie.Description,
                RuntimeMins = newMovie.RuntimeMins
                
            };
            var entity = await repo.Create(thisMovie);

            MovieDTO dto = new MovieDTO()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimeMins

            };

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepo<Movie> repo, int id, MoviePostPut movieUpdate)
        {
            var entity = await repo.Get(id);
            if(entity == null)
            {
                TypedResults.NotFound();
            }

            entity.Title = movieUpdate.Title;
            entity.Rating = movieUpdate.Rating;
            entity.Description = movieUpdate.Description;
            entity.RuntimeMins = movieUpdate.RuntimeMins;

            var result = await repo.Update(entity);
            MovieDTO dto = new MovieDTO()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimeMins,
                createdAt = entity.createdAt,
                updatedAt = entity.updatedAt
            };

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepo<Movie> repo, int id)
        {
            var entity = await repo.Delete(id);
            if(entity == null)
            {
                return TypedResults.NotFound();
            }

            MovieDTO dto = new MovieDTO()
            {
                Id = entity.Id,
                Title = entity.Title,
                Rating = entity.Rating,
                Description = entity.Description,
                RuntimeMins = entity.RuntimeMins,
                createdAt = entity.createdAt,
                updatedAt = entity.updatedAt
            };

            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);
        }

        #endregion

        #region Screening
        //SCREENING METHODS HERE

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepo<Screening> repo)
        {
            var result = await repo.GetAll();
            List<ScreeningDTO> screenings = new List<ScreeningDTO>();

            foreach (var screening in result)
            {
                ScreeningDTO dto = new ScreeningDTO()
                {
                    Id = screening.Id,
                    screenNumber = screening.screenNumber,
                    capacity = screening.capacity,
                    startsAt = screening.startsAt,
                    MovieId = screening.MovieId,
                    createdAt = screening.createdAt,
                    updatedAt = screening.updatedAt
                };
                screenings.Add(dto);
            }

            Payload<IEnumerable<ScreeningDTO>> payload = new Payload<IEnumerable<ScreeningDTO>>();
            payload.data = screenings;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepo<Screening> repo, ScreeningPost newScreening)
        {
            var thisScreening = new Screening()
            {
                screenNumber = newScreening.screenNumber,
                capacity = newScreening.capacity,
                startsAt = newScreening.startsAt,
                MovieId = newScreening.movieId
            };
            var entity = await repo.Create(thisScreening);

            ScreeningDTO dto = new ScreeningDTO()
            {
                Id = thisScreening.Id,
                screenNumber = thisScreening.screenNumber,
                capacity = thisScreening.capacity,
                startsAt = thisScreening.startsAt,
                MovieId = thisScreening.MovieId,
                createdAt = thisScreening.createdAt,
                updatedAt = thisScreening.updatedAt
            };

            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);
        }

        #endregion

        #region Ticket

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepo<Ticket> repo, int cusId, int scrId)
        {

            var result = await repo.GetAll();
            //Do i even need to call getall here if im only fetching tickets from a single customer?
            List<TicketDTO> tickets = new List<TicketDTO>();

            foreach(var ticket in result)
            {
               if(ticket.customerId == cusId && ticket.screeningId == scrId)
                {
                    TicketDTO dto = new TicketDTO()
                    {
                        Id = ticket.Id,
                        numSeats = ticket.numSeats,
                        createdAt = ticket.createdAt,
                        updatedAt = ticket.updatedAt
                    };
                    tickets.Add(dto);
                }
                
            }

            Payload<IEnumerable<TicketDTO>> payload = new Payload<IEnumerable<TicketDTO>>();
            payload.data = tickets;
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepo<Ticket> repo, TicketPost newTicket)
        {
            var ticket = new Ticket()
            {
                numSeats = newTicket.numSeats,
                customerId = newTicket.customerId,
                screeningId = newTicket.screeningId,

            };
            var entity = await repo.Create(ticket);

            TicketDTO dto = new TicketDTO()
            {
                Id = ticket.Id,
                numSeats = newTicket.numSeats,
                createdAt = ticket.createdAt,
                updatedAt = ticket.updatedAt

            };

            Payload<TicketDTO> payload = new Payload<TicketDTO>();
            payload.data = dto;
            return TypedResults.Ok(payload);
        }

        #endregion
    }
}   
