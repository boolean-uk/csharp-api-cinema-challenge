namespace api_cinema_challenge.DTO
{
    namespace api_cinema_challenge.DTO
    {
        public class ScreeningDTO
        {
            public int Id { get; set; }
            public int ScreenNumber { get; set; }
            public int Capacity { get; set; }
            public DateTime StartsAt { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime UpdatedAt { get; set; }
            public int MovieId { get; set; }
            public string MovieTitle { get; set; }
        }
    }

}
