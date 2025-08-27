using Microsoft.AspNetCore.Mvc;

public static class BookingEndpoints
{
    public static void MapBookingEndpoints(this WebApplication app)
    {
        app.MapGet("/bookings", async ([FromServices] IBookingRepository repo) =>
        {
            var bookings = await repo.GetAllAsync();

            var dtoList = bookings.Select(b => new BookingDto
            {
                CustomerId = b.CustomerId,
                MovieId = b.MovieId,
                BookedAt = b.BookedAt,
                MovieTitle = b.Movie?.Title
            });

            return Results.Ok(dtoList);
        })
        .WithTags("Bookings");


        app.MapPost("/bookings", async (CreateBookingDto dto, [FromServices] IBookingRepository repo) =>
        {
            var booking = new Booking
            {
                CustomerId = dto.CustomerId,
                MovieId = dto.MovieId
            };
            
            var createdBooking = await repo.CreateAsync(booking);

             var responseDto = new BookingDto
            {
                CustomerId = createdBooking.CustomerId,
                MovieId = createdBooking.MovieId,
            };


            return Results.Created(
                $"/bookings/{booking.CustomerId}/{booking.MovieId}",
                responseDto
            );
        })
        .WithTags("Bookings");


    }
}
