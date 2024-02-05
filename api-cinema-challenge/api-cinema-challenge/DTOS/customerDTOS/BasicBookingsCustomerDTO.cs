namespace api_cinema_challenge.Models.DTOS
{
    public record BasicBookingsCustomerDTO
    {
        public int Id { get; set; }
        public int ScreeningId { get; set; }
        public int TicketQuantity { get; set; }

        public BasicBookingsCustomerDTO(Booking booking)
        {
            Id = booking.Id;
            ScreeningId = booking.ScreeningId;
            TicketQuantity = booking.ticketQuantity;
        }
    }
}