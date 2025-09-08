using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace api_cinema_challenge.Models;

[Table("movies")]
public class Movie
{
    [Column("id", TypeName = "int")]
    public int Id { get; set; }
    
    [Column("title", TypeName = "varchar(100)")]
    public string Title { get; set; }
    
    [Column("rating", TypeName = "varchar(100)")]
    public string Rating { get; set; }
    
    [Column("description", TypeName = "varchar(500)")]
    public string Description { get; set; }
    
    [Column("runtime_mins", TypeName = "int")]
    public int RuntimeMins  { get; set; }
    
    [Column("created_at", TypeName = "timestamp with time zone")]
    public DateTime CreatedAt { get; set; }
    
    [Column("updated_at", TypeName = "timestamp with time zone")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonIgnore]
    [NotMapped]
    [Column("screenings")]
    public ICollection<Screening> Screenings { get; set; }
}