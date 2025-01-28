using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.Models.Interfaces;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movie : BaseCustomModel
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        public string Description { get; set; }
        [Column("runetime_mins")]
        public int RuntimeMins { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();

        //Navigation Properties:
        public List<Screening> Screenings { get; set; }
    }
}
