using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;
using api_cinema_challenge.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CinemaApi
{
    public static void ConfigureCinemaApi(this WebApplication app)
    {
        var cinema = app.MapGroup("cinema");

        cinema.MapPost("/customers", AddCustomer);
        cinema.MapGet("/customers", GetCustomers);
        cinema.MapPut("/customers/{id}", UpdateCustomer);
        cinema.MapDelete("/customers/{id}", DeleteCustomer);
        cinema.MapGet("/customers/{id}", GetCustomerById);
        cinema.MapPost("/movies", AddMovie);
        cinema.MapGet("/movies", GetMovies);
        cinema.MapPut("/movies/{id}", UpdateMovie);
        cinema.MapDelete("/movies/{id}", DeleteMovie);
        cinema.MapGet("/movies/{id}", GetMovieById);
        cinema.MapPost("/screenings", AddScreening);
        cinema.MapGet("/screenings", GetScreenings);
        cinema.MapGet("/screenings/{id}", GetScreeningById);
    }

    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddCustomer(IRepository<Customer> repo, CustomerPayload model)
    {
        var timeNow = DateTime.UtcNow;
        var c = new Customer()
        {
            Name = model.Name,
            Email = model.Email,
            PhoneNumber = model.Phone,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(c);
        return TypedResults.Created($"/customers/{c.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetCustomers(IRepository<Customer> repo)
    {
        var result = await repo.GetAll();
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> UpdateCustomer(IRepository<Customer> repo, int id, CustomerPayload model)
    {
        var c = await repo.GetById(id);
        c.Name = model.Name;
        c.Email = model.Email;
        c.UpdatedAt = DateTime.UtcNow;
        var result = await repo.Update(c);
        return TypedResults.Created($"/customers/{c.Id}", new ReturnValue("success", result));
    }
    
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> DeleteCustomer(IRepository<Customer> repo, int id)
    {
        var c = await repo.GetById(id);
        if (c is null) return TypedResults.NotFound($"Customer with id {id} not found");
        var result = await repo.Delete(c);
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetCustomerById(IRepository<Customer> repo, int id)
    {
        var c = await repo.GetById(id);
        return c is null ? TypedResults.NotFound($"Customer with id {id} not found") : TypedResults.Ok(new ReturnValue("success", c));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddMovie(IRepository<Movie> repo, MoviePayload model)
    {
        var timeNow = DateTime.UtcNow;
        var m = new Movie()
        {
            Title = model.Title,
            Rating = model.Rating,
            Description = model.Description,
            DurationMinutes = model.Duration,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(m);
        return TypedResults.Created($"/movies/{m.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetMovies(IRepository<Movie> repo)
    {
        var result = await repo.GetAll();
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> UpdateMovie(IRepository<Movie> repo, int id, MoviePayload model)
    {
        var m = await repo.GetById(id);
        m.Title = model.Title;
        m.Rating = model.Rating;
        m.Description = model.Description;
        m.DurationMinutes = model.Duration;
        m.UpdatedAt = DateTime.UtcNow;
        var result = await repo.Update(m);
        return TypedResults.Created($"/customers/{m.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> DeleteMovie(IRepository<Movie> repo, int id)
    {
        var m = await repo.GetById(id);
        if (m is null) return TypedResults.NotFound($"Movie with id {id} not found");
        var result = await repo.Delete(m);
        return TypedResults.Ok(new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetMovieById(IRepository<Movie> repo, int id)
    {
        var m = await repo.GetById(id);
        return m is null ? TypedResults.NotFound($"Movie with id {id} not found") : TypedResults.Ok(new ReturnValue("success", m));
    }
    
    [ProducesResponseType(StatusCodes.Status201Created)]
    private async static Task<IResult> AddScreening(IRepository<Screening> movieRepo, IRepository<Screening> repo, ScreeningPayload model)
    {
        var movie = movieRepo.GetById(model.MovieId);
        if (movie is null) return TypedResults.NotFound($"Movie with id {model.MovieId} not found");
        var timeNow = DateTime.UtcNow;
        var s = new Screening()
        {
            ScreenNumber = model.ScreenNumber,
            Capacity = model.Capacity,
            MovieId = model.MovieId,
            StartDate = model.startsAt,
            CreatedAt = timeNow,
            UpdatedAt = timeNow
        };
        var result = await repo.Add(s);
        return TypedResults.Created($"/customers/{s.Id}", new ReturnValue("success", result));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    private async static Task<IResult> GetScreenings(IRepository<Screening> repo)
    {
        var result = await repo.GetAll();
        var resultDto = result.Select(s => new ScreeningDTO()
        {
            Id = s.Id,
            ScreenNumber = s.ScreenNumber,
            Capacity = s.Capacity,
            StartsAt = s.StartDate,
            CreatedAt = s.CreatedAt,
            UpdatedAt = s.UpdatedAt
        });
        return TypedResults.Ok(new ReturnValue("success", resultDto));
    }
    
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    private async static Task<IResult> GetScreeningById(IRepository<Screening> repo, int id)
    {
        var s = await repo.GetById(id);
        return s is null ? TypedResults.NotFound($"Screening with id {id} not found") : TypedResults.Ok(new ReturnValue("success", s));
    }
}