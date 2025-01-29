namespace api_cinema_challenge.DTOs.NestedDTOs
{
    public class NestedTicketDTO
    {
        public int NumSeats { get; set; }
        public CustomerDTO Customer { get; set; }
        public NestedScreeningDTO Screening { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
