using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

[Table("screenings")]
public class Screening
{
    [Column("id", TypeName = "int")]
    public int Id { get; set; }
    
    [Column("movie_id", TypeName = "int")]
    public int MovieId { get; set; }
    
    [Column("movie")]
    public Movie Movie { get; set; }
    
    [Column("screen_number", TypeName = "int")]
    public int ScreenNumber { get; set; }
    
    [Column("capacity", TypeName = "int")]
    public int Capacity { get; set; }
   
    [Column("starts_at", TypeName = "timestamp with time zone")]
    public DateTime StartsAt { get; set; }
    
    [Column("created_at", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at", TypeName = "timestamp with time zone")]
    public DateTime UpdatedAt { get; set; }
}