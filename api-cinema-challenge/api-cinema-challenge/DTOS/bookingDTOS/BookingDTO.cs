namespace api_cinema_challenge.Models.DTOS.bookingDTOS
{
    public record BookingDTO
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public int TicketQuantity { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public BookingDTO(Booking booking)
        {
            Id = booking.Id;
            CustomerId = booking.CustomerId;
            ScreeningId = booking.ScreeningId;
            TicketQuantity = booking.ticketQuantity;
            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            CreatedAt = booking.CreatedAt.ToString(datePattern);
            UpdatedAt = booking.UpdatedAt.ToString(datePattern);
        }
    }
}