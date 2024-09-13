using api_cinema_challenge.DTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.ExpressionTranslators.Internal;

namespace api_cinema_challenge.Endpoints
{
    public static class ConfigureCinemaApis
    {


        public static void ConfigureCinemApi(this WebApplication app)
        {
            var cinemaGroup = app.MapGroup("/cinema");
            cinemaGroup.MapGet("cinema/customer", GetCustomers);
            cinemaGroup.MapPost("cinema/customer", CreateCustomer);
            cinemaGroup.MapPut("cinema/customer/{id}", EditCustomer);
            cinemaGroup.MapDelete("cinema/customer/{id}", DeleteCustomer);


            cinemaGroup.MapGet("cinema/movies", GetMovies);
            cinemaGroup.MapPost("cinema/movies", CreateMovie);
            cinemaGroup.MapPut("cinema/movies/{id}", EditMovie);
            cinemaGroup.MapDelete("cinema/movies/{id}", DeleteMovie);

            cinemaGroup.MapGet("cinema/screening/{id}", GetScreenings);
            cinemaGroup.MapPost("cinema/screening/{id}", PostScreening);

            cinemaGroup.MapGet("cinema/ticket", GetTickets);
            cinemaGroup.MapPost("cinema/ticket/{customerId}/{screeningId}", PostTicket);


        }

        public static async Task<IResult> GetCustomers(IRepository<Customer> repository)
        {
            var list = await repository.getAll();
            if (list == null)
            {
                return TypedResults.NotFound();
            }
            var DTOList = list.Select(p => new GetCustomerDTO
            {
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                email = p.Email,
                id = p.Id,
                name = p.Name,
                phone = p.Phone,

            });
            var response = new CustomAPIResponse<IEnumerable<GetCustomerDTO>>("Success", DTOList);
           
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> CreateCustomer(IRepository<Customer> repository, CreateCustomerDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }

            Customer customer = new Customer()
            {
                Email = dto.email,
                Name = dto.name,
                Phone = dto.phone,
                tickets = new List<Ticket>()
            };
            await repository.Add(customer);

            GetCustomerDTO returnDTO = new GetCustomerDTO()
            {
                createdAt = DateTime.UtcNow,
                email = dto.email,
                name = dto.name,
                phone = dto.phone,
                id = customer.Id,
                updatedAt = DateTime.UtcNow,
            };

            var response = new CustomAPIResponse<GetCustomerDTO>("Success", returnDTO);


            return TypedResults.Ok(response);
        }


        public static async Task<IResult> EditCustomer(int id, IRepository<Customer> repository, CreateCustomerDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }
            Customer customer = await repository.getbyId(id);
            customer.Email = dto.email;
            customer.Name = dto.name;
            customer.Phone = dto.phone;

            await repository.Update(customer);
            GetCustomerDTO returnDTO = new GetCustomerDTO()
            {
                createdAt = DateTime.UtcNow,
                email = customer.Email,
                name = customer.Email,
                phone = customer.Phone,
                id = customer.Id,
                updatedAt = DateTime.UtcNow,
            };
            var response = new CustomAPIResponse<GetCustomerDTO>("Success", returnDTO);

            return TypedResults.Ok(response);
        }


        public static async Task<IResult> DeleteCustomer(int id, IRepository<Customer> repository)
        {
            var Customer = await repository.getbyId(id);
            if (Customer == null)
            {
                return TypedResults.NotFound();
            }

            GetCustomerDTO dto = new GetCustomerDTO()
            {
                createdAt = DateTime.MinValue,
                updatedAt = DateTime.Now,
                email = Customer.Email,
                id = Customer.Id,
                name = Customer.Name,
                phone = Customer.Phone
            };

            await repository.Delete(id);
            var response = new CustomAPIResponse<GetCustomerDTO>("Success", dto);

            return TypedResults.Ok(response);

        }

        public static async Task<IResult> GetMovies(IRepository<Movie> repository)
        {
            var list = await repository.getAllWithIncludes();
            if (list == null)
            {
                return TypedResults.NotFound();
            }

            var DTOList = list.Select(movie => new GetMovieDTO
            {
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
                title = movie.Title,
                rating = movie.Rating,
                description = movie.Description,
                runTimemins = movie.Runtime,
                screenings = movie.screenings.Select(screening => new GetScreeningDTO
                {
                    capacity = screening.capacity,
                    screenNumber = screening.Id,
                    startTime = screening.startsAT,
                    createdAt = DateTime.UtcNow,
                    updatedAt = DateTime.UtcNow
                }).ToList()
            }).ToList();
            var response = new CustomAPIResponse<IEnumerable<GetMovieDTO>>("Success", DTOList);

            return TypedResults.Ok(response);
        }

        public static async Task<IResult> CreateMovie(IRepository<Movie> repository, CreateMovieWithScreeningDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }

            var movie = new Movie()
            {
                Title = dto.name,
                Description = dto.description,
                Rating = dto.rating,
                Runtime = dto.runTimemins,
                screenings = new List<Screening>()
            };

            var screening = new Screening()
            {
                startsAT = DateTime.UtcNow,
                capacity = dto.capacity,
                Id = dto.number,
                customers = new List<Customer>(),
                tickets = new List<Ticket>()
            };

            movie.screenings.Add(screening);

            await repository.Add(movie);

            var returnDTO = new GetMovieDTO()
            {
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
                title = dto.name,
                rating = dto.rating,
                description = dto.description,
                runTimemins = dto.runTimemins,
                screenings = new List<GetScreeningDTO>
        {
            new GetScreeningDTO
            {
                capacity = screening.capacity,
                screenNumber = screening.Id,
                startTime = screening.startsAT,
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow
            }
        }
            };
            var response = new CustomAPIResponse<GetMovieDTO>("Success", returnDTO);

            return TypedResults.Ok(response);
        }

        public static async Task<IResult> EditMovie(int id, IRepository<Movie> repository, EditMovieDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }
            Movie movie = await repository.getByIdWithIncludes(id);
            movie.Title = dto.name;
            movie.Rating = dto.rating;
            movie.Runtime = dto.runTimemins;

            await repository.Update(movie);
            GetMovieDTO returnDTO = new GetMovieDTO()
            {
                screenings = movie.screenings.Select(p => new GetScreeningDTO
                {
                    capacity = p.capacity,
                    createdAt = DateTime.UtcNow,
                    screenNumber = p.Id,
                    startTime = p.startsAT,
                    updatedAt = DateTime.UtcNow
                }).ToList(),
                createdAt = DateTime.UtcNow,
                description = movie.Description,
                rating = movie.Rating,
                runTimemins = movie.Runtime,
                title = movie.Title,
                updatedAt = DateTime.UtcNow
            };
            var response = new CustomAPIResponse<GetMovieDTO>("Success", returnDTO);
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> DeleteMovie(int id, IRepository<Movie> repository)
        {
            var movie = await repository.getByIdWithIncludes(id);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }

            GetMovieDTO dto = new GetMovieDTO()
            {
                createdAt = DateTime.MinValue,
                updatedAt = DateTime.Now,
                screenings = movie.screenings.Select(p => new GetScreeningDTO
                {
                    capacity = p.capacity,
                    createdAt = DateTime.UtcNow,
                    screenNumber = p.Id,
                    startTime = p.startsAT,
                    updatedAt = DateTime.UtcNow
                }).ToList(),
                description = movie.Description,
                rating = movie.Rating,
                runTimemins = movie.Runtime,
                title = movie.Title
            };

            await repository.Delete(id);
            var response = new CustomAPIResponse<GetMovieDTO>("Success", dto);
            return TypedResults.Ok(response);

        }

        public static async Task<IResult> GetScreenings(IRepository<Movie> repository, int id)
        {
            var movie = await repository.getByIdWithIncludes(id);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }
            var DTOList = movie.screenings.Select(p => new GetScreeningDTO
            {
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                screenNumber = p.Id,
                startTime = p.startsAT,
                capacity = p.capacity

            });
            var response = new CustomAPIResponse<IEnumerable<GetScreeningDTO>>("Success", DTOList);
            return TypedResults.Ok(response);
        }

        public static async Task<IResult> PostScreening(IRepository<Movie> repository, int id, CreateScreeningDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }
            var movie = await repository.getByIdWithIncludes(id);
            if (movie == null)
            {
                return TypedResults.NotFound();
            }

            var screening = new Screening()
            {
                startsAT = dto.startsAt,
                capacity = dto.capacity,
                Id = dto.number,
                customers = new List<Customer>(),
                tickets = new List<Ticket>()
            };

            movie.screenings.Add(screening);

            await repository.Update(movie);

            var returnDTO = new GetScreeningDTO()
            {
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
                screenNumber = dto.number,
                startTime = dto.startsAt,
                capacity = dto.capacity
            };
            var response = new CustomAPIResponse<GetScreeningDTO>("Success", returnDTO);

            return TypedResults.Ok(response);
        }

        public static async Task<IResult> GetTickets(IRepository<Customer> repository, int customerId, int screeningId)
        {
            var customer = await repository.getByIdWithIncludes(customerId);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }
            var tickets = customer.tickets.Where(p => p.screeningId == screeningId).Select(p => new GetTicketDTO
            {
                createdAt = DateTime.Now,
                updatedAt = DateTime.Now,
                id = p.Id,
                numberOfSeats = p.numOfSeats,

            });
            var response = new CustomAPIResponse<IEnumerable<GetTicketDTO>>("Success", tickets);

            return TypedResults.Ok(tickets);
        }

        public static async Task<IResult> PostTicket(IRepository<Customer> repository, int customerId, int screeningId, CreateTicketDTO dto)
        {
            if (dto == null)
            {
                return TypedResults.NotFound();
            }
            var customer = await repository.getByIdWithIncludes(customerId);
            if (customer == null)
            {
                return TypedResults.NotFound();
            }

            var ticket = new Ticket()
            {
                numOfSeats = dto.numberOfSeats,
                screeningId = screeningId,
                CustomerId = customerId
            };

            customer.tickets.Add(ticket);

            await repository.Update(customer);

            var returnDTO = new GetTicketDTO()
            {
                createdAt = DateTime.UtcNow,
                updatedAt = DateTime.UtcNow,
                id = ticket.Id,
                numberOfSeats = ticket.numOfSeats
            };

            var response = new CustomAPIResponse<GetTicketDTO>("Success", returnDTO);
            return TypedResults.Ok(response);
        }
    }
}
