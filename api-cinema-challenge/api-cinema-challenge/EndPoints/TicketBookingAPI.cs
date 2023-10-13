using api_cinema_challenge.DTOs.CustomerDTOs;
using api_cinema_challenge.DTOs.ScreeningDTOs;
using api_cinema_challenge.DTOs.TicketDTOs;
using api_cinema_challenge.Extensions;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repositories;

namespace api_cinema_challenge.EndPoints
{
    public class TicketBookingAPI
    {
        public TicketBookingAPI(WebApplication app, IDataRepository<Customer> customers, IDataRepository<Screening> screenings, IDataRepository<Ticket> tickets)
        {
            // Book a ticket for a customer for a specific screening
            app.MapPost("/customers/{customerId}/screenings/{screeningId}/tickets", async (int customerId, int screeningId, CreateTicketDto ticketRequest) =>
            {
                var customer = await customers.GetById(customerId);
                if (customer == null)
                {
                    return Results.NotFound($"Customer with ID {customerId} not found.");
                }

                var screening = await screenings.GetById(screeningId);
                if (screening == null)
                {
                    return Results.NotFound($"Screening with ID {screeningId} not found.");
                }

                var ticket = new Ticket
                {
                    CustomerId = customerId,
                    ScreeningId = screeningId,
                    NumSeats = ticketRequest.NumSeats,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await tickets.Add(ticket);

                var response = new SingleTicketDto
                {
                    Status = "success",
                    Data = new TicketWithCustomerAndScreeningDto
                    {
                        Id = ticket.Id,
                        NumSeats = ticket.NumSeats,
                        CreatedAt = ticket.CreatedAt,
                        UpdatedAt = ticket.UpdatedAt,
                        Customer = new CustomerDataDto
                        {
                            Id = customer.Id,
                            Name = customer.Name,
                            Email = customer.Email,
                            Phone = customer.Phone,
                            CreatedAt = customer.CreatedAt,
                            UpdatedAt = customer.UpdatedAt
                        },
                        Screening = new ScreeningDataDto
                        {
                            Id = screening.Id,
                            ScreenNumber = screening.ScreenNumber,
                            Capacity = screening.Capacity,
                            StartsAt = screening.StartsAt,
                            CreatedAt = screening.CreatedAt,
                            UpdatedAt = screening.UpdatedAt
                        }
                    }
                };

                return response.StandardizedCreated($"/customers/{customerId}/screenings/{screeningId}/tickets/{ticket.Id}");
            });
        }
    }
}