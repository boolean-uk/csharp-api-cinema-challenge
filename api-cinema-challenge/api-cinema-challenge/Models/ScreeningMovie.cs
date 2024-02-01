namespace api_cinema_challenge.Models
{
    public class ScreeningMovie
    {
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }


    }
}
