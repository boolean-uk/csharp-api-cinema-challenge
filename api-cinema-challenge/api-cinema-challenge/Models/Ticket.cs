using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("numSeats")]
        public int NumberOfSeats { get; set; }

        [Column("customerId")]
        [ForeignKey("customerId")]
        public int CustomerId { get; set; }

        [Column("screeningId")]
        [ForeignKey("screeningId")]
        public int ScreeningId { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("Updated At")]
        public DateTime UpdatedAt { get; set; }

        public Ticket(int numberOfSeats, int customerId, int screeningId)
        {
            NumberOfSeats = numberOfSeats;
            CustomerId = customerId;
            ScreeningId = screeningId;
            CreatedAt = DateTime.Now.ToUniversalTime();
            UpdatedAt = DateTime.Now.ToUniversalTime();
        }
    }
}
