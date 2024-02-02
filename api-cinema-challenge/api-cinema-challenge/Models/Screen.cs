namespace api_cinema_challenge.Models
{
    public class Screen
    {

        public int id {  get; set; }
        public string name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<Seat> Seats { get; set; }
        public List<Screening> Screenings { get; set; }
    }
}
