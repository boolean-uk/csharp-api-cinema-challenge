using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models;

[Table("screening")]
public class Screening
{
    [Column("id"), Key, Required]
    public int Id { get; set; }
    
    [Column("movie_fk"), ForeignKey("movie"), Required]
    public int MovieId { get; set; }
    
    [Column("movie"), Required]
    public Movie Movie { get; set; }
    
    [Column("screen_number"), Required]
    public int ScreenNumber { get; set; }
    
    [Column("capacity"), Required]
    public int Capacity { get; set; }
    
    [Column("starts_at"), Required]
    public DateTime StartsAt { get; set; }
    
    [Column("created_at"), Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Column("Updated_at"), Required]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    
    [Column("tickets"), JsonIgnore]
    public virtual ICollection<Ticket>? Tickets { get; set; } = new List<Ticket>();
}