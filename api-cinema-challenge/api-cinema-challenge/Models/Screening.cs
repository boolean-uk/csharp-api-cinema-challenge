using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    public class Screening
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public DateTime StartsAt { get; set; }
        public int Capacity { get; set; }
        public int MovieId { get; set; }

        [Column("created_at", TypeName = "timestamp")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "timestamp")]
        public DateTime UpdatedAt { get; set; }
        
        public Movie Movie { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
