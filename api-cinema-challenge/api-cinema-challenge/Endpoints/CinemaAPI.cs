
using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Request;
using api_cinema_challenge.Response;
using AutoMapper;

namespace api_cinema_challenge.Endpoints
{
    public static class CinemaAPI
    {
        public static void ConfigureCinemaAPI(this WebApplication app)
        {
            var customerGroup = app.MapGroup("/customers");
            customerGroup.MapGet("/", GetAllCustomers);
            customerGroup.MapPost("/", CreateCustomer);
            customerGroup.MapPut("/{id}", EditCustomer);
            customerGroup.MapDelete("/{id}", DeleteCustomer);
            customerGroup.MapGet("/{customerId}/screenings/{screeningId}", GetAllTickets);
            customerGroup.MapPost("/{customerId}/screenings/{screeningId}", CreateTicket);

            var movieGroup = app.MapGroup("/movies");
            movieGroup.MapPost("/", CreateMovie);
            movieGroup.MapGet("/", GetAllMovies);
            movieGroup.MapPut("/{id}", EditMovie);
            movieGroup.MapDelete("/{id}", DeleteMovie);
            movieGroup.MapGet("/{id}/screenings", GetAllScreenings);
            movieGroup.MapPost("/{id}/screenings", CreateScreening);
        }

        private static async Task<IResult> GetAllMovies(IRepository<Movie> repository, IMapper mapper)
        {
            var movies = await repository.GetAll();
            var response = mapper.Map<List<MovieDTO>>(movies);
            return TypedResults.Ok(new Response<List<MovieDTO>>("Success", response));
        }

        private static async Task<IResult> CreateMovie(IRepository<Movie> movieRepository,
                                                       IRepository<Screening> screeningRepository,
                                                       MoviePost payload,
                                                       IMapper mapper)
        {
            if(payload == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Payload at fault")));
            }
            if(payload.Title == null ||
                payload.RuntimeMinutes == null ||
                payload.Description == null ||
                payload.Rating == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Missing Title, RuntimeMinutes, Description or Rating")));
            }
            Movie movie = new Movie()
            {
                Title = payload.Title!,
                Rating = payload.Rating,
                Description = payload.Description,
                RuntimeMinutes = (int)payload.RuntimeMinutes,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            var inserted = await movieRepository.Insert(movie);

            if(payload.screenings.Count != 0)
            {
                foreach(ScreeningPost screening in payload.screenings) {
                    await screeningRepository.Insert(
                        new Screening()
                        {
                            ScreenNumber = screening.ScreenNumber,
                            StartsAt = screening.StartsAt,
                            Capacity = screening.Capacity,
                            MovieId = inserted.Id,
                            Movie = inserted,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now,
                            Tickets = new List<Ticket>()
                        });
                }
            }
            return TypedResults.Created(
                $"https://localhost:7010/movies/{inserted.Id}",
                new Response<MovieDTO>("Success", mapper.Map<MovieDTO>(inserted)));
        }

        private static async Task<IResult> EditMovie(IRepository<Movie> repository, int id, MoviePost payload, IMapper mapper)
        {
            if(payload == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Payload at fault")));
            }
            Movie movie = repository.GetById(id).Result;
            if(movie == null)
            {
                return TypedResults.NotFound(new Response<Error>("Error", new Error("Movie not Found")));
            }
            movie.Title = payload.Title ?? movie.Title;
            movie.Rating = payload.Rating ?? movie.Rating;
            movie.Description = payload.Description ?? movie.Description;
            movie.RuntimeMinutes = payload.RuntimeMinutes ?? movie.RuntimeMinutes;
            movie.UpdatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

            await repository.Update(movie);
            return TypedResults.Ok(new Response<MovieDTO>("Success", mapper.Map<MovieDTO>(movie)));

        }

        private static async Task<IResult> DeleteMovie(IRepository<Movie> repository, int id, IMapper mapper)
        {
            Movie movie = repository.GetById(id).Result;
            if(movie == null) 
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Movie not found")));
            }
            await repository.Delete(id);
            return TypedResults.Ok(new Response<MovieDTO>("Success", mapper.Map<MovieDTO>(movie)));
        }

        private static async Task<IResult> GetAllCustomers(IRepository<Customer> repository, IMapper mapper)
        {
            var customers = await repository.GetAll();
            var response = mapper.Map<List<CustomerDTO>>(customers);
            return TypedResults.Ok(new Response<List<CustomerDTO>>("Success", response));
        }

        private static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CustomerPost payload, IMapper mapper)
        {
            if (payload == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Payload at fault")));
            }
            Customer customer = new Customer()
            {
                Name = payload.Name,
                Phone = payload.Phone,
                Email = payload.Email,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            var inserted = await repository.Insert(customer);
            return TypedResults.Created($"https://localhost:7010/movies/{inserted.Id}",
                new Response<CustomerDTO>("Success", mapper.Map<CustomerDTO>(inserted)));
        }

        private static async Task<IResult> EditCustomer(IRepository<Customer> repository, int id, CustomerPost payload, IMapper mapper)
        {
            if (payload == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Payload at fault")));
            }
            Customer customer = repository.GetById(id).Result;
            customer.Name = payload.Name;
            customer.Phone = payload.Phone;
            customer.Email = payload.Email;
            customer.UpdatedAt = DateTime.Now;
            await repository.Update(customer);
            return TypedResults.Ok(new Response<CustomerDTO>("Success", mapper.Map<CustomerDTO>(customer)));
        }

        private static async Task<IResult> DeleteCustomer(IRepository<Customer> repository, int id, IMapper mapper)
        {
            Customer customer = repository.GetById(id).Result;
            if (customer == null)
            {
                return TypedResults.BadRequest(new Response<Error>("Error", new Error("Customer not found")));
            }
            await repository.Delete(id);
            return TypedResults.Ok(new Response<CustomerDTO>("Success", mapper.Map<CustomerDTO>(customer)));
        }

        /**
         * TODO
         * Get all screenings for movie
         */

        private static async Task<IResult> GetAllScreenings(IRepository<Screening> repository, int id, IMapper mapper)
        {
            List<Screening> screenings = repository.GetQueryable()
                .Where(x => x.MovieId == id)
                .ToList();
            var response = mapper.Map<List<ScreeningDTO>>(screenings);
            return TypedResults.Ok(new Response<List<ScreeningDTO>>("Success", response));
        }


        /**
         * TODO
         * Integrate Id to request
         */
        private static async Task<IResult> CreateScreening(IRepository<Screening> repository, int id, ScreeningPost payload, IMapper mapper)
        {
            {
                if (payload == null)
                {
                    return TypedResults.BadRequest(new Response<Error>("Error", new Error("Payload at fault")));
                }
                Screening screening = new Screening()
                {
                    ScreenNumber = payload.ScreenNumber,
                    StartsAt = payload.StartsAt,
                    Capacity = payload.Capacity,
                    MovieId = id,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                var inserted = await repository.Insert(screening);
                return TypedResults.Created($"https://localhost:7010/movies/{inserted.Id}",
                    new Response<ScreeningDTO>("Success", mapper.Map<ScreeningDTO>(inserted)));
            }
        }

        private static async Task<IResult> GetAllTickets(IRepository<Ticket> repository, int customerId, int screeningId, IMapper mapper)
        {
            List<Ticket> tickets = repository.GetQueryable()
                .Where(x => x.CustomerId == customerId)
                .Where(x => x.ScreeningId == screeningId)
                .ToList();
            if(tickets.Count == 0)
            {
                return TypedResults.Ok(new Response<Error>("Error", new Error($"Customer {customerId} has no tickets for Screening {screeningId}")));
            }
            return TypedResults.Ok(new Response<List<MinimalTicketDTO>>("Success", mapper.Map<List<MinimalTicketDTO>>(tickets)));
        }

        private static async Task<IResult> CreateTicket(IRepository<Ticket> ticketRepository,
                                                        IRepository<Screening> screeningRepository,
                                                        IRepository<Customer> customerRepository,
                                                        TicketPost payload,
                                                        int customerId,
                                                        int screeningId,
                                                        IMapper mapper)
        {
            Customer customer = customerRepository.GetById(customerId).Result;
            Screening screening = screeningRepository.GetById(screeningId).Result;
            if (screening == null)
            {
                return TypedResults.NotFound(new Response<Error>("Error", new Error("Screening was not found")));
            }
            if (customer == null)
            {
                return TypedResults.NotFound(new Response<Error>("Error", new Error("Customer was not found")));
            }
            Ticket ticket = new Ticket()
            {
                NumSeats = payload.NumSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Customer = customer,
                Screening = screening
            };
            await ticketRepository.Insert(ticket);
            return TypedResults.Ok(new Response<MinimalTicketDTO>("Success", mapper.Map<MinimalTicketDTO>(ticket)));
        }
    }
}
