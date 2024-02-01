using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model {

    [Table("tickets")]
    public class Ticket
{
    [Column("id")]
    public int Id { get; set; }

    [Column("num_seats")]
    public int NumSeats { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("movie_id")]
    public int MovieId { get; set; }
    public Movie Movie { get; set; } = null!;

    [Column("screening_id")]
    public int ScreeningId { get; set; }
    public Screening Screening { get; set; } = null!;

    [Column("customer_id")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
}
}