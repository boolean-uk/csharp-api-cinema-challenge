namespace api_cinema_challenge.Models.DTOs
{
    public class TicketResponseDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public string MovieTitle { get; set; }
        public string UserName { get; set; }

        public TicketResponseDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            MovieTitle = ticket.Movie.Title;
            UserName = ticket.User.Name;
        }
    }
}
