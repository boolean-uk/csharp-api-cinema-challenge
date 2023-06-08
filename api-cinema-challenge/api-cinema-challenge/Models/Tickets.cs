using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public int numSeats { get; set; }

        [ForeignKey("Screenings")]
        public int ScreenId { get; set; }
        public Screenings Screenings { get; set; }

        
    }
}
