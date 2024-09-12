using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

[Table("screenings")]
public class Screening
{
    [Column("id")]
    public int Id { get; set; }
    [Column("screen_id")]
    public int ScreenNumber { get; set; }
    [Column("capacity")]
    public int Capacity { get; set; }
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    [ForeignKey("movie_id")]
    public int MovieId { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    public Movie Movie { get; set; }
}