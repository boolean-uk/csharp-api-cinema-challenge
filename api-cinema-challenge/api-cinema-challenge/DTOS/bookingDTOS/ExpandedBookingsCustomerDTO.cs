using api_cinema_challenge.Models.DTOS.movieDTOS;

namespace api_cinema_challenge.Models.DTOS.bookingDTOS
{
    public record ExpandedBookingsCustomerDTO
    {
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public int TicketQuantity { get; set; }
        public DateTime StartsAt { get; set; }
        public float TotalPrice { get; set; }
        public CustomerMovieBookingDTO Movie { get; set; }

        public ExpandedBookingsCustomerDTO(Booking booking)
        {
            Id = booking.Id;
            ScreeningId = booking.ScreeningId;
            TicketQuantity = booking.ticketQuantity;
            Movie = new CustomerMovieBookingDTO(booking.Screening.Movie);
            StartsAt = booking.Screening.StartsAt;
            TotalPrice = booking.Screening.Price * TicketQuantity;
        }
    }
}