namespace api_cinema_challenge.Models.DTOs
{
    public class AddScreeningDTO
    {
        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
