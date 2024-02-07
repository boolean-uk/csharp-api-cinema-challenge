namespace api_cinema_challenge.Models.ScreeningModels
{
    public class OutputScreening
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime StartsAt { get; set; }

        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }
    }
}
