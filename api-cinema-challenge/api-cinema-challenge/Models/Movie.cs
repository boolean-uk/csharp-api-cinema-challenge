using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;
/*
"data": {

    "id": 1,
    "title": "Dodgeball",
    "rating": "PG-13",
    "description": "The greatest movie ever made.",
    "runtimeMins": 126,
    "createdAt": "2023-03-14T11:01:56.633+00:00",
    "updatedAt": "2023-03-14T11:01:56.633+00:00"

}
*/
[Table("movies")]
public class Movie
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("rating")]
    public string Rating { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("runtime_mins")]
    public int RuntimeMins { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    public IEnumerable<Screening> Screenings { get; set; }
}
