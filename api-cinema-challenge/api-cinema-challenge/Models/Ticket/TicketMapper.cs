namespace api_cinema_challenge.Models.Ticket
{
    public static class TicketMapper
    {
        public static TicketDTO MapToDTO(this Ticket ticket)
        {
            return new TicketDTO
            {
                Id = ticket.Id,
                numSeats = ticket.numSeats,
                createdAt = ticket.createdAt,
                updatedAt = ticket.updatedAt,
            };
        }

        public static List<TicketDTO> MapToDTO(this List<Ticket> tickets)
        {
            return tickets.Select(ticket => new TicketDTO
            {
                Id = ticket.Id,
                numSeats = ticket.numSeats,
                createdAt = ticket.createdAt,
                updatedAt = ticket.updatedAt,
            }).ToList();
        }
    }
}
