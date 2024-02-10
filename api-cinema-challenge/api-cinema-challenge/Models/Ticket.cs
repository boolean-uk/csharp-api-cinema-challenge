using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("num_of_seats")]
        public int NumSeats { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }

        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public User User {  get; set; }
        public int UserId { get; set; }
    }
}
