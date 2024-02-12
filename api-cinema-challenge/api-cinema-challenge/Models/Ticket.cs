using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models
{
    [Table("ticket")]
    public class Ticket
    {
        [Column("id")] public int Id { get; set; }
        [Column("customer_id")] [ForeignKey("customer_id")] public int CustomerId { get; set; }
        [Column("screening_id")] [ForeignKey("screening_id")] public int ScreeningId { get; set; }
        [Column("num_seats")] public int NumSeats { get; set; }
        [Column("date_created")] public DateTime DateCreated { get; set; }
        [Column("date_updated")] public DateTime DateUpdated { get; set; }

        [JsonIgnore] public Customer Customer { get; set; }
        [JsonIgnore] public Screening Screening { get; set; }
    }
}
