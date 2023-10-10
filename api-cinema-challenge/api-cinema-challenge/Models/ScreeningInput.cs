namespace api_cinema_challenge.Models.Screening
{
    public class ScreeningInput
    {
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }
    }
}
