using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaEndpoint
    {
        public static void ConfigureCinemaEndpoint(this WebApplication app)
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            Payload<List<CustomerDto>> output = new();
            output.data = new();
            foreach (Customer customer in await repository.Get())
            {
                output.data.Add(new CustomerDto(customer));
            }

            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, PostCustomer createCustomer)
        {
            Payload<CustomerDto> output = new();
            var movies = await repository.Get();

            Customer customer = new(createCustomer);
            customer.Id = movies.Last().Id + 1;


            output.data = new CustomerDto(await repository.Create(customer));
            return TypedResults.Created($"/{output.data.Id}", output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, PostCustomer updateCustomer)
        {
            Payload<CustomerDto> output = new();
            Customer customer = await repository.GetById(id);
            if (customer == null)
            {
                output.status = "not found";
                return TypedResults.NotFound(output);
            }

            customer.Name = updateCustomer.Name != null ? updateCustomer.Name : output.data.Name;
            customer.Email = updateCustomer.Email != null ? updateCustomer.Email : output.data.Email;
            customer.Phone = updateCustomer.Phone != null ? updateCustomer.Phone : output.data.Phone;
            customer.UpdatedAt = DateTime.UtcNow;

            output.data = new CustomerDto(await repository.Update(customer));
            return TypedResults.Created($"", output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Payload<CustomerDto> output = new();
            Customer customer = await repository.GetById(id);
            if (customer == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            output.data = new CustomerDto(await repository.Delete(id));
            if (output.data == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            return TypedResults.Ok(output);
        }
        #endregion

        #region Movies
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            Payload<List<GetMovieDto>> output = new();
            output.data = new();
            foreach (Movie movie in await repository.Get())
            {
                output.data.Add(new GetMovieDto(movie));
            }

            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, PostMovie createMovie)
        {
            Payload<GetMovieDto> output = new();
            var movies = await repository.Get();

            Movie movie = new(createMovie);
            movie.Id = movies.Last().Id + 1;


            output.data = new GetMovieDto(await repository.Create(movie));
            return TypedResults.Created($"/{output.data.Id}", output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateMovie(IRepository<Movie> repository, int id, PutMovie updateMovie)
        {
            Payload<GetMovieDto> output = new();
            Movie movie = await repository.GetById(id);
            if (movie == null)
            {
                output.status = "not found";
                return TypedResults.NotFound(output);
            }

            movie.Title = updateMovie.Title != null ? updateMovie.Title : output.data.Title;
            movie.Description = updateMovie.Description != null ? updateMovie.Description : output.data.Description;
            movie.Rating = updateMovie.Rating != null ? updateMovie.Rating : output.data.Rating;
            movie.RuntimeMins = (int)(updateMovie.RuntimeMins != null ? updateMovie.RuntimeMins : output.data.RuntimeMins);
            movie.UpdatedAt = DateTime.UtcNow;

            output.data = new GetMovieDto(await repository.Update(movie));
            return TypedResults.Created($"", output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id)
        {
            Payload<GetMovieDto> output = new();

            var movie = await repository.GetById(id);
            if (movie == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            output.data = new GetMovieDto(await repository.Delete(id));
            if (output.data == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            return TypedResults.Ok(output);
        }
        #endregion

        #region Screenings
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository, int id)
        {
            Payload<List<ScreeningDto>> output = new();
            output.data = new();
            IEnumerable<Screening> data = (await repository.Get()).Where(x => x.MovieId == id);
            foreach (Screening screening in data)
            {
                output.data.Add(new ScreeningDto(screening));
            }

            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, PostScreening createScreening)
        {
            Payload<GetScreeningDto> output = new();
            var screenings = await repository.Get();

            Screening screening = new(createScreening);
            screening.Id = screenings.Last().Id + 1;
            screening.MovieId = id;


            output.data = new GetScreeningDto(await repository.Create(screening));
            return TypedResults.Created($"/{output.data.Id}", output);
        }
        #endregion

        #region Tickets
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetTickets(IRepository<Ticket> repository, int customerId, int screeningId)
        {
            Payload<List<TicketDto>> output = new();
            output.data = new();
            IEnumerable<Ticket> data = (await repository.Get()).Where(x => x.CustomerId == customerId && x.ScreeningId == screeningId);
            foreach (Ticket ticket in data)
            {
                output.data.Add(new TicketDto(ticket));
            }

            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateTicket(IRepository<Ticket> repository, int customerId, int screeningId, PostTicket createTicket)
        {
            Payload<TicketDto> output = new();
            var tickets = await repository.Get();

            Ticket ticket = new(createTicket);
            ticket.Id = tickets.Last().Id + 1;
            ticket.CustomerId = customerId;
            ticket.ScreeningId = screeningId;

            output.data = new TicketDto(await repository.Create(ticket));
            return TypedResults.Created($"/{output.data.Id}", output);

        }
        #endregion
    }
}
