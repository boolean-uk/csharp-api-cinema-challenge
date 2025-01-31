using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

/*
"data": {

    "id": 1,
    "screenNumber": 5,
    "capacity": 40,
    "startsAt": "2023-03-19T11:30:00.000+00:00",
    "createdAt": "2023-03-14T11:01:56.633+00:00",
    "updatedAt": "2023-03-14T11:01:56.633+00:00"

}
*/

[Table("screenings")]
public class Screening
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("starts_at")]
    public DateTime StartsAt { get; set; }

    [ForeignKey("Movie")]
    public int MovieId { get; set; }

    public Movie Movie { get; set; }

    [Column("screen_number")]
    public int ScreenNumber { get; set; }

    [Column("capacity")]
    public int Capacity { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

}
