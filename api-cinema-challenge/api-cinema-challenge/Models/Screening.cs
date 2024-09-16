using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
     [Key]
     [Column("id")]
     public int Id { get; set; }

     [Column("screennumber")]
     public int ScreenNumber { get; set; }

     [Column("capacity")]
     public int Capacity { get; set; }
        
     [Column("startsAt")]
     public DateTime StartsAt { get; set; }

     [Column("createdAt")]
     public DateTime CreatedAt { get; set; }

     [Column("updatedAt")]
     public DateTime updatedAt { get; set; }

     //linking to foreign keys


    }
}
