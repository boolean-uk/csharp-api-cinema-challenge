using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models;

[Table("movie")]
public class Movie
{
  [Column("id"), Required, Key]
  public int Id { get; set; }
  
  [Column("title"), MaxLength(128), Required]
  public string Title { get; set; }
  
  [Column("rating"), Required]
  public double Rating { get; set; }
  
  [Column("description"), MaxLength(1024), Required]
  public string Description { get; set; }
  
  [Column("run_time_minutes"), Required]
  public int RuntimeMins{ get; set; }

  [Column("created_at"), Required] 
  public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  
  [Column("updated_at"), Required] 
  public DateTime UpdatedAt { get; set; } = DateTime.UtcNow; //Assumes creation counts as an update
  
  [Column("screenings"), JsonIgnore, Required]
  public virtual ICollection<Screening> Screenings { get; set; } = new List<Screening>();
}