using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaAPI
    {
        public static void ConfigureCinemaApi(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("cinema");

            cinemaGroup.MapGet("/customers", GetCustomers);
            cinemaGroup.MapPost("/customers", AddCustomer);
            cinemaGroup.MapPut("/customers/{id}", UpdateCustomer);
            cinemaGroup.MapDelete("/customers/{id}", DeleteCustomer);

            cinemaGroup.MapGet("/movies", GetMovies);
            cinemaGroup.MapPost("/movies", AddMovie);
            cinemaGroup.MapPut("/movies/{id}", UpdateMovie);
            cinemaGroup.MapDelete("/movies/{id}", DeleteMovie);

            cinemaGroup.MapGet("/movies/{id}/screenings", GetScreenings);
            cinemaGroup.MapPost("/movies/{id}/screenings", AddScreening);

            cinemaGroup.MapGet("/customer/{customerid}/screenings/{screeningid}", GetTickets);
            cinemaGroup.MapPost("/customer/{customerid}/screenings/{screeningid}", AddTickets);
        }

        public static async Task<IResult> GetCustomers(IRepository repository)
        {
            return TypedResults.Ok(await repository.GetCustomers());
        }

        public static async Task<IResult> AddCustomer(IRepository repository, CustomerPost model)
        {
            Customer customer = new Customer
            {
                Name = model.Name,
                Email = model.Email,
                Phone = model.Phone,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            var result = await repository.AddCustomer(customer);
            return TypedResults.Created($"https://localhost:7195/customers/{result.Id}", result);
        }

        public static async Task<IResult> UpdateCustomer(IRepository repository, int id, CustomerPut model)
        {
            try
            {
                var target = await repository.GetCustomer(id);
                if (target == null) return TypedResults.NotFound("Product was not found");

                if (model.Name != null) target.Name = model.Name;
                if (model.Email != null) target.Email = model.Email;
                if (model.Phone != null) target.Phone = model.Phone;
                target.UpdatedAt = DateTime.UtcNow;
                var result = await repository.UpdateCustomer(target);
                
                return Results.Created($"https://localhost:7195/customers/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteCustomer(IRepository repository, int id)
        {
            try
            {
                var model = await repository.GetCustomer(id);
                if (model == null)
                    return TypedResults.NotFound("Book was not found");
                if (await repository.DeleteCustomer(id)) return Results.Ok(new { When = DateTime.UtcNow, Status = "Deleted", Name = model.Name, Email = model.Email, Phone = model.Phone });
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetMovies(IRepository repository)
        {
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            var result = await repository.GetMovies();
            foreach (var movie in result)
            {
                MovieDTO movieDTO = new MovieDTO
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Description = movie.Description,
                    Rating = movie.Rating,
                    RuntimeMins = movie.RuntimeMins,
                    CreatedAt = movie.CreatedAt,
                    UpdatedAt = movie.UpdatedAt,
                };
                movieDTOs.Add(movieDTO);
            }


            return TypedResults.Ok(movieDTOs);
        }

        public static async Task<IResult> AddMovie(IRepository repository, MoviePost model)
        {
            
            

            Movie movie = new Movie
            {
                Title = model.Title,
                Description = model.Description,
                Rating = model.Rating,
                RuntimeMins = model.RuntimeMins,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            var result = await repository.AddMovie(movie);

            foreach (var screen in model.screenings)
            {
                Screening screening = new Screening()
                {
                    ScreenNumber = screen.ScreenNumber,
                    MovieId = movie.Id,
                    StartTime = screen.StartTime,
                    Capacity = screen.Capacity,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
                var screenResult = await repository.AddScreening(screening);
            }


            return Results.Created($"https://localhost:7195/movies/{result.Id}", result);
        }

        public static async Task<IResult> UpdateMovie(IRepository repository, int id, MoviePut model)
        {
            try
            {
                var target = await repository.GetMovie(id);
                if (target == null) return TypedResults.NotFound("Movie was not found");

                if (model.Title != null) target.Title = model.Title;
                if (model.Description != null) target.Description = model.Description;
                if (model.Rating != null) target.Rating = model.Rating;
                if (model.RuntimeMins != null) target.RuntimeMins = model.RuntimeMins.Value;
                target.UpdatedAt = DateTime.UtcNow;

                var result = await repository.UpdateMovie(target);

                return Results.Created($"https://localhost:7195/movies/{result.Id}", result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> DeleteMovie(IRepository repository, int id)
        {
            try
            {
                var model = await repository.GetMovie(id);
                if (model == null)
                    return TypedResults.NotFound("Movie was not found");
                if (await repository.DeleteMovie(id)) return Results.Ok(new { When = DateTime.UtcNow, Status = "Deleted", Title = model.Title, Description = model.Description, Rating = model.Rating, RuntimeMins= model.RuntimeMins });
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        public static async Task<IResult> AddScreening(IRepository repository, int id, ScreeningPost model)
        {
            Screening screening = new Screening
            {
                MovieId = id,
                ScreenNumber = model.ScreenNumber,
                Capacity = model.Capacity,
                StartTime = model.StartTime,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            var result = await repository.AddScreening(screening);
            return Results.Created($"https://localhost:7195/movies/{result.Id}", result);

        }

        public static async Task<IResult> GetScreenings(IRepository repository, int id)
        {
            var result = await repository.GetScreenings(id);
            return TypedResults.Ok(result);

        }

        public static async Task<IResult> GetTickets(IRepository repository, int CustomerId, int ScreeningId)
        {
            var result = await repository.GetTickets(CustomerId, ScreeningId);
            List<TicketDTO> ticketDTOs = new List<TicketDTO>();
            foreach (var ticket in result)
            {
                TicketDTO ticketDTO = new TicketDTO
                {
                    Id = ticket.Id,
                    NumSeats = ticket.NumSeats,
                    UpdatedAt = ticket.UpdatedAt,
                    CreatedAt = ticket.CreatedAt,
                };
                ticketDTOs.Add(ticketDTO);
            }
            return TypedResults.Ok(ticketDTOs);
        }

        public static async Task<IResult> AddTickets(IRepository repository, int CustomerId, int ScreeningId, TicketPost model)
        {
            Ticket ticket = new Ticket
            {
                CustomerId = CustomerId,
                ScreeningId = ScreeningId,
                NumSeats = model.Numseats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            var result = await repository.AddTicket(ticket);

            TicketDTO ticketDTO = new TicketDTO
            {
                Id = ticket.Id,
                NumSeats = model.Numseats,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
            return TypedResults.Ok(ticketDTO);
        }


    }
}
