using System;
using System.Net.Http.Headers;
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.Replication;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints;

public static class CinemaEndpoints
{



    public static void ConfigureCinemaEndpoint(this WebApplication app)
    {
        var cinema = app.MapGroup("/Cinema");


        // Customer endpoints
        cinema.MapPost("/customers", CreateCustomer);
        cinema.MapGet("/customers", GetAllCustomers);
        cinema.MapPut("/customers/{id}", UpdateCustomer);
        cinema.MapDelete("/customers/{id}", DeleteCustomer);

        //Movie endpoints
        cinema.MapPost("/movies", CreateMovie);
        cinema.MapGet("/movies", GetAllMovies);
        cinema.MapPut("/customer/{id}", UpdateMovie);
        cinema.MapDelete("/customer/{id}", DeleteMovie);

        //Screen endpoints
        cinema.MapPost("/screens", CreateScreen);
        cinema.MapGet("/screens", GetAllScreens);
        cinema.MapPut("/screens", UpdateScreen);
        cinema.MapDelete("/screens", DeleteScreen);

        //Ticket endpoints
        cinema.MapGet("/tickets", GetAllTickets);
        cinema.MapPost("/tickets", CreateTicket);

        //Screening endpoints (entity named screenmovie)
        cinema.MapGet("/screening", GetAllScreenMovies);
        cinema.MapPost("/screening", CreateScreenMovie);

    }
    #region CustomerEndpoints
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async static Task<IResult> CreateCustomer(ICinemaRepository<Customer> cinemaRepository, IMapper mapper, CreateCustomerDTO createCustomerDTO)
    {
        Customer customerToCreate = mapper.Map<Customer>(createCustomerDTO);
        Func<Customer, bool> email_exists = c => c.Email == customerToCreate.Email;
        Func<Customer, bool> name_exists = c => c.Name == customerToCreate.Name;
        Func<Customer, bool> phone_exists = c => c.Phone == customerToCreate.Phone;
        if (cinemaRepository.Exists(email_exists)) //Check if email exists 
        {
            return TypedResults.Conflict($"Email ({customerToCreate.Email}) already exists!");
        }
        if (cinemaRepository.Exists(name_exists)) //Check if name exists
        {
            return TypedResults.Conflict($"Name ({customerToCreate.Name}) already exists!");
        }
        if (cinemaRepository.Exists(phone_exists)) //Check if phone nr exists
        {
            return TypedResults.Conflict($"Phone ({customerToCreate.Phone}) already exists!");
        }
       
        Customer createdCustomer = await cinemaRepository.CreateEntity(customerToCreate);

        Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO> {Data = mapper.Map<GetCustomerDTO>(createdCustomer)};
        
        return TypedResults.Ok(payload);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetAllCustomers(ICinemaRepository<Customer> cinemaRepository, IMapper mapper)
    {
        
        IEnumerable<Customer> customers = await cinemaRepository.GetAll();
        Payload<List<GetCustomerDTO>> payload = new Payload<List<GetCustomerDTO>>() {Data = mapper.Map<List<GetCustomerDTO>>(customers)};

        return TypedResults.Ok(payload);

    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public static async Task<IResult> UpdateCustomer(ICinemaRepository<Customer> cinemaRepository, IMapper mapper, int id, CreateCustomerDTO updated)
    {
        Customer customerToUpdate = mapper.Map<Customer>(updated);

        Func<Customer, bool> email_exists = c => c.Email == customerToUpdate.Email;
        Func<Customer, bool> name_exists = c => c.Name == customerToUpdate.Name;
        Func<Customer, bool> phone_exists = c => c.Phone == customerToUpdate.Phone;
        if (cinemaRepository.Exists(email_exists)) //Check if email exists 
        {
            return TypedResults.Conflict($"Email ({customerToUpdate.Email}) already exists!");
        }
        if (cinemaRepository.Exists(name_exists)) //Check if name exists
        {
            return TypedResults.Conflict($"Name ({customerToUpdate.Name}) already exists!");
        }
        if (cinemaRepository.Exists(phone_exists)) //Check if phone nr exists
        {
            return TypedResults.Conflict($"Phone ({customerToUpdate.Phone}) already exists!");
        }
        
        Customer customer = await cinemaRepository.UpdateEntityById(id, customerToUpdate);

        if (customer == null)
        {
        return TypedResults.BadRequest($"Could not find customer with id={id}");
        }
        Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO>() {Data = mapper.Map<GetCustomerDTO>(customer)};
        return TypedResults.Ok(payload);
    }

    public static async Task<IResult> DeleteCustomer(ICinemaRepository<Customer> cinemaRepository, IMapper mapper, int id)
    {
        Customer deletedCustomer = await cinemaRepository.DeleteEntityById(id);

        if (deletedCustomer == null)
        {
            return TypedResults.NotFound($"Could not find customer with id={id}");
        }

        Payload<GetCustomerDTO> payload = new Payload<GetCustomerDTO>() {Data = mapper.Map<GetCustomerDTO>(deletedCustomer)};

        return TypedResults.Ok(payload);
    }



    #endregion


    #region MovieEndpoints

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async static Task<IResult> CreateMovie(ICinemaRepository<Movie> cinemaRepository, IMapper mapper, CreateMovieDTO createMovieDTO)
    {
        Movie movieToCreate = mapper.Map<Movie>(createMovieDTO);
        Func<Movie, bool> title_exists = c => c.Title == movieToCreate.Title;
      
        if (cinemaRepository.Exists(title_exists)) //Check if email exists 
        {
            return TypedResults.Conflict($"Title ({movieToCreate.Title}) already exists!");
        }
        
       
        Movie createdMovie = await cinemaRepository.CreateEntity(movieToCreate);

        Payload<GetMovieDTO> payload = new Payload<GetMovieDTO> {Data = mapper.Map<GetMovieDTO>(createdMovie)};
        
        return TypedResults.Ok(payload);
    }

    public static async Task<IResult> GetAllMovies(ICinemaRepository<Movie> cinemaRepository, IMapper mapper)
    {
        IEnumerable<Movie> movies = await cinemaRepository.GetAll();
        Payload<List<GetMovieDTO>> payload = new Payload<List<GetMovieDTO>>() {Data = mapper.Map<List<GetMovieDTO>>(movies)};

        return TypedResults.Ok(payload);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public static async Task<IResult> UpdateMovie(ICinemaRepository<Movie> cinemaRepository, IMapper mapper, int id, CreateMovieDTO updated)
    {
        Movie movieToUpdate = mapper.Map<Movie>(updated);

        Func<Movie, bool> title_exists = m => m.Title == movieToUpdate.Title;
        
        if (cinemaRepository.Exists(title_exists)) //Check if email exists 
        {
            return TypedResults.Conflict($"Title ({movieToUpdate.Title}) already exists!");
        }
       
        
        Movie movie = await cinemaRepository.UpdateEntityById(id, movieToUpdate);

        if (movie == null)
        {
        return TypedResults.BadRequest($"Could not find movie with id={id}");
        }
        Payload<GetMovieDTO> payload = new Payload<GetMovieDTO>() {Data = mapper.Map<GetMovieDTO>(movie)};
        return TypedResults.Ok(payload);
    }
    
    public static async Task<IResult> DeleteMovie(ICinemaRepository<Movie> cinemaRepository, IMapper mapper, int id)
    {
        Movie deletedMovie = await cinemaRepository.DeleteEntityById(id);

        if (deletedMovie == null)
        {
            return TypedResults.NotFound($"Could not find movie with id={id}");
        }

        Payload<GetMovieDTO> payload = new Payload<GetMovieDTO>() {Data = mapper.Map<GetMovieDTO>(deletedMovie)};

        return TypedResults.Ok(payload);
    }
    #endregion

    #region Screen

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async static Task<IResult> CreateScreen(ICinemaRepository<Screen> cinemaRepository, IMapper mapper, CreateScreenDTO createScreenDTO)
    {
        Screen screenToCreate = mapper.Map<Screen>(createScreenDTO);
        Func<Screen, bool> screennr_exists = s => s.ScreenNumber == screenToCreate.ScreenNumber;
     
        if (cinemaRepository.Exists(screennr_exists)) //Check if screen exists 
        {
            return TypedResults.Conflict($"ScreenNr ({screenToCreate.ScreenNumber}) already exists!");
        }
       
       
        Screen createdScreen = await cinemaRepository.CreateEntity(screenToCreate);

        Payload<GetScreenDTO> payload = new Payload<GetScreenDTO> {Data = mapper.Map<GetScreenDTO>(createdScreen)};
        
        return TypedResults.Ok(payload);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetAllScreens(ICinemaRepository<Screen> cinemaRepository, IMapper mapper)
    {
        
        IEnumerable<Screen> screens = await cinemaRepository.GetAll();
        Payload<List<GetScreenDTO>> payload = new Payload<List<GetScreenDTO>>() {Data = mapper.Map<List<GetScreenDTO>>(screens)};

        return TypedResults.Ok(payload);

    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public static async Task<IResult> UpdateScreen(ICinemaRepository<Screen> cinemaRepository, IMapper mapper, int id, CreateScreenDTO updated)
    {
        Screen screenToUpdate = mapper.Map<Screen>(updated);

        Func<Screen, bool> screennr_exists = s => s.ScreenNumber == screenToUpdate.ScreenNumber;

        if (cinemaRepository.Exists(screennr_exists)) //Check if email exists 
        {
            return TypedResults.Conflict($"ScreenNr ({screenToUpdate.ScreenNumber}) already exists!");
        }

        
        Screen screen = await cinemaRepository.UpdateEntityById(id, screenToUpdate);

        if (screen == null)
        {
        return TypedResults.BadRequest($"Could not find screen with id={id}");
        }
        Payload<GetScreenDTO> payload = new Payload<GetScreenDTO>() {Data = mapper.Map<GetScreenDTO>(screen)};
        return TypedResults.Ok(payload);
    }

    public static async Task<IResult> DeleteScreen(ICinemaRepository<Screen> cinemaRepository, IMapper mapper, int id)
    {
        Screen deletedScreen = await cinemaRepository.DeleteEntityById(id);

        if (deletedScreen == null)
        {
            return TypedResults.NotFound($"Could not find customer with id={id}");
        }

        Payload<GetScreenDTO> payload = new Payload<GetScreenDTO>() {Data = mapper.Map<GetScreenDTO>(deletedScreen)};

        return TypedResults.Ok(payload);
    }

    #endregion

    #region ScreenMovie

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async static Task<IResult> CreateScreenMovie(ICinemaRepository<ScreenMovie> cinemaSMRepository, ICinemaRepository<Screen> cinemaScreenRepository, IMapper mapper, CreateScreenMovieDTO createScreenMovieDTO)
    {
        ScreenMovie screenMovieToCreate = mapper.Map<ScreenMovie>(createScreenMovieDTO);
        Func<ScreenMovie, bool> screenmovie_exists = sm => sm.MovieId == screenMovieToCreate.MovieId
                                                            && sm.ScreenId == screenMovieToCreate.ScreenId
                                                            && DateTime.Equals(sm.StartsAt, screenMovieToCreate.StartsAt);
     
        if (cinemaSMRepository.Exists(screenmovie_exists)) //Check if ScreenMovie exists
        {
            return TypedResults.Conflict($"ScreenMovie with screenId=({screenMovieToCreate.ScreenId}), movieId={screenMovieToCreate.ScreenId}, and starttime={screenMovieToCreate.StartsAt} already exists!");
        }
       
        // Set the number of available seats to the capacity of the screen
        Screen screen = await cinemaScreenRepository.GetEntityById(screenMovieToCreate.ScreenId);
        screenMovieToCreate.AvailableSeats = screen.Capacity;

        //Create screenmovie
        ScreenMovie createdScreen = await cinemaSMRepository.CreateEntity(screenMovieToCreate);

        Payload<GetScreenMovieDTO> payload = new Payload<GetScreenMovieDTO> {Data = mapper.Map<GetScreenMovieDTO>(createdScreen)};
        
        return TypedResults.Ok(payload);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetAllScreenMovies(ICinemaRepository<ScreenMovie> cinemaRepository, IMapper mapper)
    {
        
        IEnumerable<ScreenMovie> screens = await cinemaRepository.GetAll();
        Payload<List<GetScreenMovieDTO>> payload = new Payload<List<GetScreenMovieDTO>>() {Data = mapper.Map<List<GetScreenMovieDTO>>(screens)};

        return TypedResults.Ok(payload);

    }

    #endregion

    #region Ticket
    [ProducesResponseType(StatusCodes.Status200OK)]
    public static async Task<IResult> GetAllTickets(ICinemaRepository<Ticket> cinemaRepository, IMapper mapper)
    {
        
        IEnumerable<Ticket> tickets = await cinemaRepository.GetAll();
        Payload<List<GetTicketDTO>> payload = new Payload<List<GetTicketDTO>>() {Data = mapper.Map<List<GetTicketDTO>>(tickets)};

        return TypedResults.Ok(payload);

    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async static Task<IResult> CreateTicket(ICinemaRepository<Ticket> cinemaTicketRepository, ICinemaRepository<ScreenMovie> cinemaSMRepository, IMapper mapper, CreateTicketDTO createTicketDTO)
    {
        Ticket ticketToCreate = mapper.Map<Ticket>(createTicketDTO);

        //Check if there is available seats
        ScreenMovie sm = await cinemaSMRepository.GetEntityById(ticketToCreate.ScreenMovieId);
        if (ticketToCreate.NumSeats >= sm.AvailableSeats)
        {
            return TypedResults.Conflict($"Screening has only {sm.AvailableSeats} left!");
        }
        
     
        //Update the amount of available seats for this screening
        await cinemaSMRepository.UpdateEntityById(sm.Id, new ScreenMovie() {AvailableSeats = sm.AvailableSeats - ticketToCreate.NumSeats});

        Ticket createdTicket = await cinemaTicketRepository.CreateEntity(ticketToCreate);

        

        Payload<GetTicketDTO> payload = new Payload<GetTicketDTO> {Data = mapper.Map<GetTicketDTO>(createdTicket)};
        
        return TypedResults.Ok(payload);
    }

    #endregion
}