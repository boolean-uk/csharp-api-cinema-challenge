using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

/**
 * "data": {

    "id": 1,
    "name": "Chris Wolstenholme",
    "email": "chris@muse.mu",
    "phone": "+44729388192",
    "createdAt": "2023-03-14T11:01:56.633+00:00",
    "updatedAt": "2023-03-14T11:01:56.633+00:00"

}
 */
[Table("customers")]
public class Customer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("phone")]
    public string Phone { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    public IEnumerable<Ticket> Tickets { get; set; }
}