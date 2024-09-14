﻿using api_cinema_challenge.DTO;
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
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel model)
        {
            try
            {
                Payload<Customer> payload = new Payload<Customer>();

                return TypedResults.Ok();
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
        public static async Task<IResult> UpdateCustomerById(IRepository repository, int id)
        {
            try
            {
                Payload<Customer> payload = new Payload<Customer>();

                return TypedResults.Ok();
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
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel model)
        {
            try
            {
                Payload<Movie> payload = new Payload<Movie>();

                return TypedResults.Ok();
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
        public static async Task<IResult> UpdateMovieById(IRepository repository, int id)
        {
            try
            {
                Payload<Movie> payload = new Payload<Movie>();

                return TypedResults.Ok();
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
                return TypedResults.Ok();
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
                Payload<Screening> payload = new Payload<Screening>();

                return TypedResults.Ok();
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
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
