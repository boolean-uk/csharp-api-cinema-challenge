namespace api_cinema_challenge.Model.DTOs
{
    public class ScreeningDto
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public int MovieId { get; set; } // FK
    }
}
