using api_cinema_challenge.DTOs.CustomerDTOs;
using api_cinema_challenge.DTOs.TicketDTOs;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace api_cinema_challenge.Endpoints
{
    public static class CustomerEndpoints
    {
        public static void ConfigureCustomerEndpoint(this WebApplication app)
        {
            var customers = app.MapGroup("customers");

            customers.MapGet("/{id}", GetCustomerById).RequireAuthorization();
            customers.MapGet("/", GetCustomers).RequireAuthorization("Admin");
            customers.MapPost("/", AddCustomer).RequireAuthorization(); // both roles can add customers
            customers.MapDelete("/{id}", DeleteCustomer).RequireAuthorization("Admin");
            customers.MapPut("/{id}", UpdateCustomer).RequireAuthorization(); 

            // ticket endpoints
            customers.MapPost("/{customerId}/screenings/{screeningId}", AddTicket).RequireAuthorization();
            customers.MapGet("/{customerId}/screenings/{screeningId}", GetTickets).RequireAuthorization();
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomerById(int id, IRepository<Customer> repository)
        {
            var targetCustomer = await repository.GetById(id);
            if (targetCustomer == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Customer with id {id} not found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var customerDto = new CustomerDto
            {
                Id = targetCustomer.Id,
                Name = targetCustomer.Name,
                Email = targetCustomer.Email,
                Phone = targetCustomer.Phone,
                CreatedAt = targetCustomer.CreatedAt,
                UpdatedAt = targetCustomer.UpdatedAt
            };

            var response = new
            {
                status = "success",
                data = customerDto
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetCustomers(IRepository<Customer> repository, ClaimsPrincipal user)
        {
            var username = user.Identity?.Name;

            var customers = await repository.GetAll();
            if (customers == null || !customers.Any())
            {
                var errorResponse = new
                {
                    status = "error",
                    message = "No customers found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var customerDto = customers.Select(c => new CustomerDto { Id = c.Id,
                Name = c.Name,
                Email = c.Email,
                Phone = c.Phone,
                CreatedAt = c.CreatedAt,
                UpdatedAt = c.UpdatedAt
            }).ToList();

            var response = new
            {
                status = "success",
                requestedBy = username, // included who requested the customer list
                data = customerDto
            };

            return TypedResults.Ok(response);

        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddCustomer(IRepository<Customer> repository, [FromBody] CustomerPostDto model, IValidator<CustomerPostDto> validator, HttpRequest request)
        {
            if (model == null) { return TypedResults.BadRequest("Invalid customer data"); }

            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }

            var newCustomer = new Customer { Name = model.Name, Email = model.Email, Phone = model.Phone, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow };
            var addedCustomer = await repository.Add(newCustomer);

            var customerDto = new CustomerDto { Id = addedCustomer.Id, Name = addedCustomer.Name, Email=addedCustomer.Email, Phone = addedCustomer.Phone, CreatedAt = addedCustomer.CreatedAt, UpdatedAt = addedCustomer.UpdatedAt };

            var response = new
            {
                status = "success",
                data = customerDto
            };

            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/customers/{addedCustomer.Id}";
            return TypedResults.Created(location, response);
        
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteCustomer(int id, IRepository<Customer> repository, ClaimsPrincipal user)
        {
            var username = user.Identity?.Name;

            var targetCustomer = await repository.GetById(id);
            if (targetCustomer == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Customer with id {id} not found."
                };
                return TypedResults.NotFound(errorResponse);
            }

            var deletedCustomer = await repository.Delete(id);

            var customerDto = new CustomerDto
            {
                Id = deletedCustomer.Id,
                Name = deletedCustomer.Name,
                Email = deletedCustomer.Email,
                Phone = deletedCustomer.Phone,
                CreatedAt = deletedCustomer.CreatedAt,
                UpdatedAt = deletedCustomer.UpdatedAt
            };

            var response = new
            {
                status = "success",
                deletedBy = username, // included who deleted the customer
                data = customerDto
            };

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateCustomer(int id, IRepository<Customer> repository, [FromBody] CustomerPutDto model, IValidator<CustomerPutDto> validator, HttpRequest request)
        {
            // check if the customer we want to update exists
            var existingCustomer = await repository.GetById(id);
            if (existingCustomer == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"The customer you want to update with ID {id} does not exist"
                };
                return TypedResults.NotFound(errorResponse);
            }

            if (model == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = "Invalid customer data"
                };
                return TypedResults.BadRequest(errorResponse);
            }

            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }

            // check if the new name already exists for another customer
            var allCustomers = await repository.GetAll();
            var duplicateNameCustomer = allCustomers.FirstOrDefault(
                c => c.Name == model.Name && c.Id != id);
            if (duplicateNameCustomer != null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"A customer with the name '{model.Name}' already exists."
                };
                return TypedResults.BadRequest(errorResponse);
            }

            // update the customer
            if (!string.IsNullOrWhiteSpace(model.Name)) existingCustomer.Name = model.Name;
            if (!string.IsNullOrWhiteSpace(model.Email)) existingCustomer.Email = model.Email;
            if (!string.IsNullOrWhiteSpace(model.Phone)) existingCustomer.Phone = model.Phone;

            // set UpdatedAt to now
            existingCustomer.UpdatedAt = DateTime.UtcNow;

            var updatedCustomer = await repository.Update(id, existingCustomer);

            // generate respone dto
            var customerDto = new CustomerDto { Id = updatedCustomer.Id, Name = updatedCustomer.Name, Email = updatedCustomer.Email, Phone = updatedCustomer.Phone };

            var response = new
            {
                status = "success",
                data = customerDto
            };

            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/customers/{updatedCustomer.Id}";
            return TypedResults.Created(location, response);

        }

        // ticket endpoints

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AddTicket(int customerId, int screeningId, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository, IRepository<Ticket> ticketRepository, [FromBody] TicketPostDto model, IValidator<TicketPostDto> validator, HttpRequest request)
        {
            // check if the customer exists
            var existingCustomer = await customerRepository.GetById(customerId);
            if (existingCustomer == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"The customer with ID {customerId} does not exist"
                };
                return TypedResults.NotFound(errorResponse);
            }
            // check if the screening exists
            var existingScreening = await screeningRepository.GetById(screeningId);
            if (existingScreening == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"The screening with ID {screeningId} does not exist"
                };
                return TypedResults.NotFound(errorResponse);
            }
            if (model == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = "Invalid ticket data"
                };
                return TypedResults.BadRequest(errorResponse);
            }
            var validationResult = await validator.ValidateAsync(model);
            if (!validationResult.IsValid)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = string.Join("; ", validationResult.Errors.Select(e => e.ErrorMessage))
                };
                return TypedResults.BadRequest(errorResponse);
            }
            // create the ticket
            var newTicket = new Ticket
            {
                NumSeats = model.NumSeats,
                CustomerId = customerId,
                ScreeningId = screeningId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
            var addedTicket = await ticketRepository.Add(newTicket);
            var ticketDto = new TicketDto
            {
                Id = addedTicket.Id,
                NumSeats = addedTicket.NumSeats,
                CreatedAt = addedTicket.CreatedAt,
                UpdatedAt = addedTicket.UpdatedAt
            };
            var response = new
            {
                status = "success",
                data = ticketDto
            };
            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
            var location = $"{baseUrl}/tickets/{addedTicket.Id}";
            return TypedResults.Created(location, response);
        }

        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetTickets(int customerId, int screeningId, IRepository<Ticket> ticketRepository, IRepository<Customer> customerRepository, IRepository<Screening> screeningRepository)
        {
            // Check if customer exists
            var customer = await customerRepository.GetById(customerId);
            if (customer == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Customer with ID {customerId} does not exist"
                };
                return TypedResults.NotFound(errorResponse);
            }

            // Check if screening exists
            var screening = await screeningRepository.GetById(screeningId);
            if (screening == null)
            {
                var errorResponse = new
                {
                    status = "error",
                    message = $"Screening with ID {screeningId} does not exist"
                };
                return TypedResults.NotFound(errorResponse);
            }

            // Get all tickets for this customer and screening
            var tickets = await ticketRepository.GetAll();
            var filteredTickets = tickets
                .Where(t => t.CustomerId == customerId && t.ScreeningId == screeningId)
                .Select(t => new
                {
                    id = t.Id,
                    numSeats = t.NumSeats,
                    createdAt = t.CreatedAt.ToString("yyyy-MM-ddTHH:mm:ss"),
                    updatedAt = t.UpdatedAt.ToString("yyyy-MM-ddTHH:mm:ss")
                })
                .ToList();

            var response = new
            {
                status = "success",
                data = filteredTickets
            };

            return TypedResults.Ok(response);
        }

    }
}
