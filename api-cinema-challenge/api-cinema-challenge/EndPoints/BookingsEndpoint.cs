using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Mvc;
using api_cinema_challenge.Models.DTOs;

namespace workshop.wwwapi.Endpoints
{
    public class BookingPayload
    {
        // Assuming the payload would at least contain a MovieId and a list of seat IDs for the booking
        
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        
        public int NumberOfSeats { get; set; }


        public bool AllFieldsFilled()
        {
            return ScreeningId != null && NumberOfSeats > 0;
        }
    }

    public static class BookingEndpoint
    {
        public static void ConfigureBookingEndpoint(this WebApplication app)
        {
            var bookingGroup = app.MapGroup("/bookings");

            bookingGroup.MapPost("/", CreateBooking);
            bookingGroup.MapGet("/", GetAllBookings);
            bookingGroup.MapGet("/{id}", GetBookingById);
            bookingGroup.MapDelete("/{id}", DeleteBooking);
        }

        public static async Task<IResult> GetAllBookings(IBookingRepository repository)
        {
            var bookings = await repository.GetAll();
            if (bookings.Count == 0) return Results.NotFound("No bookings found.");

            return Results.Ok(BookingDTO.FromListOfBookings(bookings)); 
        }

        public static async Task<IResult> GetBookingById(int id, IBookingRepository repository)
        {
            var booking = await repository.GetBookingById(id);
            if (booking == null) return Results.NotFound($"Booking with ID {id} not found.");

            return Results.Ok(BookingDTO.FromBooking(booking)); 
        }

        public static async Task<IResult> CreateBooking(BookingPayload payload, IBookingRepository repository)
        {
            if (!payload.AllFieldsFilled()) {return Results.BadRequest("All required fields must be filled.");}

            List<Ticket> tickets = await repository.GetAvailableTicketsForScreening(payload.ScreeningId);

            if(tickets.Count < payload.NumberOfSeats) { return Results.BadRequest("Not enough available seats."); }
            
            List<int> ticketIDs = tickets.Take(payload.NumberOfSeats).Select(ticket => ticket.Id).ToList();

            var newBooking = new Booking
            {
                CustomerId = payload.CustomerId,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            var createdBooking = await repository.CreateABooking(newBooking, ticketIDs);
            return Results.Created($"/bookings/{createdBooking.Id}", BookingDTO.FromBooking(createdBooking));
        }

        public static async Task<IResult> DeleteBooking(int id, IBookingRepository repository)
        {
            var deletedBooking = await repository.DeleteABooking(id);
            if (deletedBooking == null) return Results.NotFound($"Booking with ID {id} not found.");

            return Results.Ok(BookingDTO.FromBooking(deletedBooking));
        }
    }
}
