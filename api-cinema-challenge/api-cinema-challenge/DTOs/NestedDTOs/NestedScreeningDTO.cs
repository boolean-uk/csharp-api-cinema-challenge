namespace api_cinema_challenge.DTOs.NestedDTOs
{
    public class NestedScreeningDTO
    {
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
        public int Capacity { get; set; }
        public MovieDTO Movie { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
