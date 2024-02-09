using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class DtMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
         public int Rating { get; set; }
        public string Description { get; set; }
        public double RunTime { get; set; }
        public DateTime CreatedAt {get; set; }
         public DateTime UpdatedAt { get; set; }

     //   public ICollection<DtScreening> Screenings { get; set; } = new List<DtScreening>();

    }
}
