using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Column("seatNumber")]
        public int SeatNumber { get; set; }
        [Column("createdAt")]
        public DateTime CreatedAt { get; internal set; }
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; internal set; }

        [ForeignKey("customerID")]
        [Column("customerID")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("screeningID")]
        [Column("screeningID")]
        public int ScreeningId { get; set; }
        [JsonIgnore]
        public Screening Screening { get; set; }

    }
}
