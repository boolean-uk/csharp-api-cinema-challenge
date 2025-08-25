using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models;

[Table("customer")]
public class Customer
{
    [Column("id"), Required, Key]
    public int Id { get; set; }
    
    [Column("name"), MaxLength(128), Required]
    public string Name { get; set; }
    
    [Column("email"), MaxLength(256), Required]
    public string Email { get; set; }
    
    [Column("phone"), MaxLength(32), Required]
    public string Phone { get; set; }
    
    [Column("created_at"), Required]
    public DateTime CreatedAt { get; set; }  = DateTime.UtcNow;
    
    [Column("updated_at"), Required]
    public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
    
    [Column("tickets"), JsonIgnore]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}