using api_cinema_challenge.DTO;
using api_cinema_challenge.DTO.GetResponses;
using api_cinema_challenge.DTO.ViewModels;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaAPI
    {
        public static void ConfigureCinemaEnpoint(this WebApplication app)
        {
            var cinema = app.MapGroup("cinema");

            cinema.MapGet("/customers", GetCustomers);
            cinema.MapGet("/movies", GetMovies);
            cinema.MapGet("/movies/{id}/screenings", GetScreenings);
            cinema.MapPost("/customers", CreateCustomer);
            cinema.MapPost("/movies", CreateMovie);
            cinema.MapPost("/movies/{id}/screenings", CreateScreening);
            cinema.MapPut("/customers/{id}", UpdateCustomer);
            cinema.MapPut("/movies/ {id}", UpdateMovie);
            cinema.MapDelete("/customers/{id}", DeleteCustomer);
            cinema.MapDelete("/movies/{id}", DeleteMovie);
        }


        //getters
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            GetCustomerResponse response = new GetCustomerResponse();
            var results = await repository.GetAllCustomers();

            foreach (Customer result in results)
            {
                CustomerDTO dto = new CustomerDTO() { 
                    Id = result.Id,
                    Name = result.Name,
                    Email = result.Email,
                    Phone = result.Phone,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Customers.Add(dto);
            }
            return TypedResults.Ok(response.Customers);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetMovies(IRepository repository)
        {
            GetMovieResponse response = new GetMovieResponse();
            var results = await repository.GetAllMovies();

            foreach (Movie result in results)
            {
                MovieDTO dto = new MovieDTO()
                {
                    Id = result.Id,
                    Title = result.Title,
                    Description = result.Description,
                    RuntimeMins = result.RuntimeMins,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Movies.Add(dto);
            }
            return TypedResults.Ok(response.Movies);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetScreenings(IRepository repository, int movieId)
        {

            GetScreeningResponse response = new GetScreeningResponse();
            var results = await repository.GetAllCScreenings(movieId);

            foreach (Screening result in results)
            {
                ScreeningDTO dto = new ScreeningDTO()
                {
                    Id = result.Id,
                    ScreenNumber = result.ScreenNumber,
                    Capacity = result.Capacity,
                    StartsAt = result.StartsAt,
                    CreatedAt = result.CreatedAt,
                    UpdatedAt = result.UpdatedAt
                };

                response.Screenings.Add(dto);
            }
            return TypedResults.Ok(response.Screenings);
        }

        //creates
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateCustomer(IRepository repository, CustomerPostModel model)
        {
            Customer customer = await repository.CreateACustomer(new Customer() { Name = model.Name, Email = model.Email, Phone = model.Phone});

            var response = await repository.GetCustomerById(customer.Id);


            Payload<CustomerDTO> payload = new Payload<CustomerDTO>();
            payload.Data = new CustomerDTO()
            {
                Id = response.Id,
                Name = response.Name,
                Email = response.Email,
                Phone = response.Phone,
                CreatedAt = response.CreatedAt,
                UpdatedAt = response.UpdatedAt

            };

            return TypedResults.Ok(payload.Data);
        }  
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IRepository repository, MoviePostModel model)
        {
            Movie movie = await repository.CreateAMovie(new Movie() { Title = model.Title, Rating = model.Rating, Description = model.Description, RuntimeMins = model.RuntimeMins });

            
            Payload<MovieDTO> payload = new Payload<MovieDTO>();
            payload.Data = new MovieDTO()
            {
                Id=movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                RuntimeMins = movie.RuntimeMins,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAt,

            };

           


            return TypedResults.Ok(payload.Data);
        } 
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateScreening(IRepository repository, ScreeningPostModel model, int id)
        {


            Screening screening = await repository.CreateScreening(new Screening() { ScreenNumber = model.ScreenNumber, Capacity = model.Capcity, StartsAt = model.StartsAt,  MovieId = id});


            Payload<ScreeningDTO> payload = new Payload<ScreeningDTO>();
            payload.Data = new ScreeningDTO()
            {
             Id = screening.Id,
             ScreenNumber = screening.ScreenNumber,
             Capacity  = screening.Capacity,
             StartsAt = screening.StartsAt,
             CreatedAt  = screening.CreatedAt,
             UpdatedAt = screening.UpdatedAt

            };




            return TypedResults.Ok(payload.Data); 
        }  
        
        //updates
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateCustomer(IRepository repository, CustomerPostModel model, int id)
        {
            var response = await repository.GetCustomerById(id);
            response.Name = model.Name;
            response.Email = model.Email;
            response.Phone = model.Phone;
            response.UpdatedAt = DateTime.UtcNow;


            Payload<Customer> payload = new Payload<Customer>() { 
                Data = response
            };

            await repository.UpdateACustomer(payload.Data);


            CustomerDTO customerDTO = new CustomerDTO()
            {
                Id = response.Id,
                Name = response.Name,
                Email = response.Email,
                Phone = response.Phone,
                CreatedAt = response.CreatedAt,
                UpdatedAt = response.UpdatedAt
            };
            return TypedResults.Ok(customerDTO);
        } 
        
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovie(IRepository repository, MoviePostModel model, int id )
        {
            var response = await repository.GetMovieById(id);
            response.Title = model.Title;
            response.Rating = model.Rating;
            response.Description = model.Description;
            response.RuntimeMins = model.RuntimeMins;
            response.UpdatedAt = DateTime.UtcNow;


            Payload<Movie> payload = new Payload<Movie>()
            {
                Data = response
            };

            await repository.UpdateAMovie(payload.Data);


            MovieDTO movieDTO = new MovieDTO()
            {
                Id = response.Id,
                Title = response.Title,
                Rating = response.Rating,
                Description = response.Description,
                CreatedAt = response.CreatedAt,
                UpdatedAt = response.UpdatedAt
            };
            return TypedResults.Ok(movieDTO);
        }


        //deletes
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            var target = await repository.DeleteACustomer(id);

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
        
        
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {

            var target = await repository.DeleteAMovie(id);

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

    }
}
