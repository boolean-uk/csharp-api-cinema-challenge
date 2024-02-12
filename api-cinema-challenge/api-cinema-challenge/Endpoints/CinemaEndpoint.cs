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

            cinemaGroup.MapGet("screenings/", GetScreenings);
            cinemaGroup.MapPost("screenings/", CreateScreening);
        }

        #region Customers
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            Payload<IEnumerable<Customer>> output = new() { data = await repository.Get() };
            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, PostCustomer newCustomer)
        {
            Payload<Customer> output = new();
            var customers = await repository.Get();
            Customer customer = new();

            customer.Id = customers.Last().Id+1;
            customer.Name = newCustomer.Name;
            customer.Email = newCustomer.Email;
            customer.Phone = newCustomer.Phone;
            customer.CreatedAt = DateTime.UtcNow;
            customer.UpdatedAt = DateTime.UtcNow;
            output.data = await repository.Create(customer);

            return TypedResults.Created($"/{output.data.Id}",output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository<Customer> repository, int id, UpdateCustomerDto updateCustomer)
        {
            Payload<Customer> output = new() { data = await repository.GetById(id) };
            var customers = await repository.Get();

            output.data.Name = updateCustomer.Name != null ? updateCustomer.Name : output.data.Name;
            output.data.Email = updateCustomer.Email != null ? updateCustomer.Email : output.data.Email;
            output.data.Phone = updateCustomer.Phone != null ? updateCustomer.Phone : output.data.Phone;
            output.data.UpdatedAt = DateTime.UtcNow;

            repository.Update(output.data);
            return TypedResults.Created($"", output);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id)
        {
            Payload<Customer> output = new();
            var customer = await repository.GetById(id);
            if (customer == null)
            {
                output.status = "failed";
                return TypedResults.NotFound(output);
            }
            output.data = await repository.Delete(id);
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
            IEnumerable<Movie> data = await repository.Get();
            foreach (Movie movie in data)
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
            Movie oldMovie = await repository.GetById(id);
            var movie = await repository.GetById(id);
            if (movie == null)
            {
                output.status = "not found";
                return TypedResults.NotFound(output);
            }

            oldMovie.Title = updateMovie.Title != null ? updateMovie.Title : output.data.Title;
            oldMovie.Description = updateMovie.Description != null ? updateMovie.Description : output.data.Description;
            oldMovie.Rating = updateMovie.Rating != null ? updateMovie.Rating : output.data.Rating;
            oldMovie.RuntimeMins = (int)(updateMovie.RuntimeMins != null ? updateMovie.RuntimeMins : output.data.RuntimeMins);

            output.data = new GetMovieDto(await repository.Update(oldMovie));
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
        public static async Task<IResult> GetScreenings(IRepository<Screening> repository)
        {
            Payload<List<GetScreeningDto>> output = new();
            output.data = new();
            IEnumerable<Screening> data = await repository.Get();
            foreach (Screening screening in data)
            {
                output.data.Add(new GetScreeningDto(screening));
            }

            return TypedResults.Ok(output);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository<Screening> repository, PostScreening createScreening)
        {
            Payload<GetScreeningDto> output = new();
            var screenings = await repository.Get();

            Screening screening = new(createScreening);
            screening.Id = screenings.Last().Id + 1;


            output.data = new GetScreeningDto(await repository.Create(screening));
            return TypedResults.Created($"/{output.data.Id}", output);
        }
        #endregion
    }
}
