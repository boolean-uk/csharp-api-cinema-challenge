using api_cinema_challenge.Models;
using api_cinema_challenge.Models.DTOS.bookingDTOS;
using api_cinema_challenge.Repositories.customer;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class BookingEndpoints
    {
        public static void ConfigureBookingEndpoints(this WebApplication app)
        {
            var bookings = app.MapGroup("/bookings");

            bookings.MapPost("", CreateBooking);
            bookings.MapGet("", GetAllBookings);
            app.MapGet("/customers/{customerId}/Bookings", GetAllBookingsByCustomer);
            bookings.MapDelete("/{id}", DeleteBookingById);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private async static Task<IResult> CreateBooking(IBookingRepository repository, int customerId, BookingPayload payload)
        {
            if (payload.CheckPayload() != string.Empty)
            {
                return TypedResults.BadRequest(payload.CheckPayload());
            }
            try
            {
                var booking = await repository.Add(customerId, payload.ScreeningId, payload.ticketQuantity);
                return booking == null ? TypedResults.NotFound("Customer or Screening was not found") : TypedResults.Created($"/customers/{customerId}", new BookingDTO(booking));
            }
            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private async static Task<IResult> GetAllBookings(IBookingRepository repository)
        {
            var allBookings = await repository.GetAll();
            var resultBooking = new List<BookingDTO>();
            if (allBookings.Count == 0) { return TypedResults.NotFound("No bookings where found"); }

            foreach (var booking in allBookings)
            {
                resultBooking.Add(new BookingDTO(booking));
            }

            return TypedResults.Ok(resultBooking);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private async static Task<IResult> GetAllBookingsByCustomer(IBookingRepository repository, int customerId)
        {
            var allBookings = await repository.GetAllByCustomer(customerId);
            var resultBooking = new List<ExpandedBookingsCustomerDTO>();
            if (allBookings.Count == 0) { return TypedResults.NotFound("No bookings where found"); }

            foreach (var booking in allBookings)
            {
                resultBooking.Add(new ExpandedBookingsCustomerDTO(booking));
            }

            return TypedResults.Ok(resultBooking);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private async static Task<IResult> DeleteBookingById(IBookingRepository repository, int id)
        {
            var booking = await repository.Delete(id);
            return booking == null ? TypedResults.NotFound("Booking not found") : TypedResults.Ok(new BookingDTO(booking));
        }
    }
}
