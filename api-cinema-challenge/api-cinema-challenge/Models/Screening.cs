using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    
    public class Screening
    {

        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public  int ScreenId { get; set; }
        public Screen Screen { get; set; }

        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

       
        public List<Ticket> Tickets{ get; set; }
    }
}
