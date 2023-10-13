using api_cinema_challenge.DTOs.CustomerDTOs;
using api_cinema_challenge.DTOs.TicketDTOs;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public class CustomerManagementAPI
    {
        public CustomerManagementAPI(WebApplication app, IDataRepository<Customer> customers)
        {
            // Create a new customer
            app.MapPost("/customers", async (CreateCustomerDto dto) =>
            {
                var newCustomer = new Customer
                {
                    Name = dto.Name,
                    Email = dto.Email,
                    Phone = dto.Phone,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                };
                await customers.Add(newCustomer);
                var response = new SingleCustomerDto
                {
                    Status = "success",
                    Data = new CustomerDataDto
                    {
                        Id = newCustomer.Id,
                        Name = newCustomer.Name,
                        Email = newCustomer.Email,
                        Phone = newCustomer.Phone,
                        CreatedAt = newCustomer.CreatedAt,
                        UpdatedAt = newCustomer.UpdatedAt
                    }
                };
                return response.StandardizedCreated($"/customers/{newCustomer.Id}");
            });

            // Get all customers
            app.MapGet("/customers", async () =>
            {
                var allCustomers = await customers.GetAll();
                var customerDtos = allCustomers.Select(c => new CustomerWithTicketsDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    Email = c.Email,
                    Phone = c.Phone,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    Tickets = c.Tickets.Select(t => new TicketDataDto
                    {
                        Id = t.Id,
                        NumSeats = t.NumSeats,
                        CreatedAt = t.CreatedAt,
                        UpdatedAt = t.UpdatedAt
                    }).ToList()
                }).ToList();

                return new AllCustomersDto
                {
                    Status = "success",
                    Data = customerDtos
                }.StandardizedOk();
            });

            // Get a specific customer by ID
            app.MapGet("/customers/{id}", async (int id) =>
            {
                var customer = await customers.GetById(id);
                if (customer == null)
                {
                    return Results.NotFound($"Customer with ID {id} not found.");
                }

                var customerDto = new CustomerWithTicketsDto
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    Email = customer.Email,
                    Phone = customer.Phone,
                    CreatedAt = customer.CreatedAt,
                    UpdatedAt = customer.UpdatedAt,
                    Tickets = customer.Tickets.Select(t => new TicketDataDto
                    {
                        Id = t.Id,
                        NumSeats = t.NumSeats,
                        CreatedAt = t.CreatedAt,
                        UpdatedAt = t.UpdatedAt
                    }).ToList()
                };

                return new SingleCustomerDto
                {
                    Status = "success",
                    Data = customerDto
                }.StandardizedOk();
            });

            // Update a customer
            app.MapPut("/customers/{id}", async (int id, UpdateCustomerDto dto) =>
            {
                var existingCustomer = await customers.GetById(id);
                if (existingCustomer == null)
                {
                    return Results.NotFound($"Customer with ID {id} not found.");
                }

                if (!string.IsNullOrEmpty(dto.Name)) existingCustomer.Name = dto.Name;
                if (!string.IsNullOrEmpty(dto.Email)) existingCustomer.Email = dto.Email;
                if (!string.IsNullOrEmpty(dto.Phone)) existingCustomer.Phone = dto.Phone;
                existingCustomer.UpdatedAt = DateTime.UtcNow;

                await customers.Update(existingCustomer);

                var customerDto = new CustomerDataDto
                {
                    Id = existingCustomer.Id,
                    Name = existingCustomer.Name,
                    Email = existingCustomer.Email,
                    Phone = existingCustomer.Phone,
                    CreatedAt = existingCustomer.CreatedAt,
                    UpdatedAt = existingCustomer.UpdatedAt
                };

                return new SingleCustomerDto
                {
                    Status = "success",
                    Data = customerDto
                }.StandardizedOk();
            });

            // Delete a customer
            app.MapDelete("/customers/{id}", async (int id) =>
            {
                await customers.Delete(id);
                return Results.Ok($"Customer with ID {id} has been deleted.");
            });
        }
    }
}