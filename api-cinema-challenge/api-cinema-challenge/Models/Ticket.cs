using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        [Column("ticket_id")]
        public int Id { get; set; }

        [Column("seat_number")]
        public int SeatNumber { get; set; }

    
        [Column("created_at", TypeName = "Date")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at", TypeName = "Date")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("screening_id")]
        public int ScreeningId { get; set; }
        public Screening Screening { get; set; }

        [ForeignKey("custommer_id")]
        public int CustommerId { get; set; }
        public Custommer Custommer { get; set; }




    }
}
