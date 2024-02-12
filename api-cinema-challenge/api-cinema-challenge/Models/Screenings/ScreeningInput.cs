namespace api_cinema_challenge.Models.Screenings
{
    public struct ScreeningInput
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
