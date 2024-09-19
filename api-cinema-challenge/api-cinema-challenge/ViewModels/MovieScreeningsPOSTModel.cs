namespace api_cinema_challenge.ViewModels
{
    public class MovieScreeningsPOSTModel
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }

    }
}
