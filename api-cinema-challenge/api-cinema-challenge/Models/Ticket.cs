using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cinema_challenge.Models;

[Table("ticket")]
public class Ticket
{
   [Column("id"), Required, Key]
   public int Id { get; set; }
   
   [Column("num_seats"), Required]
   public int NumSeats { get; set; }
   
   [Column("screening_fk"), ForeignKey("screening"), Required]
   public int ScreeningId { get; set; }
   
   [Column("customer_fk"), ForeignKey("customer"),Required]
   public int CustomerId { get; set; }
   
   [Column("screening"),Required]
   [JsonIgnore]
   public Screening Screening { get; set; }
   
   [Column("customer"),Required]
   [JsonIgnore]
   public Customer Customer { get; set; }
   
   [Column("created_at"), Required]
   public DateTime CreatedAt { get; set; }  = DateTime.UtcNow;
   [Column("Updated_at"), Required]
   public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
}