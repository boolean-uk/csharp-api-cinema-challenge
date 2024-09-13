namespace api_cinema_challenge.Models.Dtos
{
    public class CreateScreeningDto
    {
        public int screenNumber { get; set; }
        public int capacity { get; set; }
        public DateTime startsAt { get; set; }

    }
}
