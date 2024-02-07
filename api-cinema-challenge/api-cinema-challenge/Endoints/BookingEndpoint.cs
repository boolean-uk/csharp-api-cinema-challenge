using api_cinema_challenge.Model;
using api_cinema_challenge.Model.DTOs;
using api_cinema_challenge.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Endoints
{
    public static class BookingEndpoint
    {
        public static void ConfigureBookingEndpoint(this WebApplication app)
        {
            var bookingGroup = app.MapGroup("booking");

            // Booking endpoints
            bookingGroup.MapGet("/bookings" , GetBookings);
            bookingGroup.MapGet("/bookings/{id}" , GetBookingById);
            bookingGroup.MapPost("/bookings" , CreateBooking);
            bookingGroup.MapDelete("/bookings/{id}" , DeleteBooking);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBookings(IBookingRepository repository)
        {
            return TypedResults.Ok(await repository.GetAllBookings());
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBookingById(IBookingRepository repository , int id)
        {
            var booking = await repository.GetBooking(id);
            if(booking == null)
            {
                return Results.NotFound($"Booking with ID {id} not found.");
            }
            return Results.Ok(booking);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateBooking(IBookingRepository repository , BookingDto bookingDto)
        {
            var booking = new Booking
            {
                CustomerId = (bookingDto.CustomerId) ,
                ScreeningId = bookingDto.ScreeningId ,
                NumberOfSeats = bookingDto.NumberOfSeats ,
                Seats = bookingDto.SeatIds.Select(id => new Seat { Id = id }).ToList()
            };

            booking = await repository.CreateBooking(booking);
            return Results.Created($"/bookings/{booking.Id}" , booking);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteBooking(IBookingRepository repository , int id)
        {
            var booking = await repository.DeleteBooking(id);
            if(booking == null)
            {
                return Results.NotFound($"Booking with ID {id} not found.");
            }
            return Results.Ok(booking);
        }
    }
}
