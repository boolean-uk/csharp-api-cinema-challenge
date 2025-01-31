using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

/*
"data": {

    "id": 1,
    "numSeats": 3,
    "createdAt": "2023-03-14T11:01:56.633+00:00",
    "updatedAt": "2023-03-14T11:01:56.633+00:00"

}
*/
[Table("tickets")]
public class Ticket
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("num_seats")]
    public int NumSeats { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [ForeignKey("Screening")]
    public int ScreeningId { get; set; }
    public Screening Screening { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

    public Customer Customer { get; set; }
}
