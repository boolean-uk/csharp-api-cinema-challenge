using api_cinema_challenge.Models.Domain.AbstractClasses;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Domain.Entities.MoviesAndScreenings
{
    public enum MovieRating
    {
        [Description("G")]
        G,
        [Description("PG")]
        PG,
        [Description("PG-13")]
        PG13,
        [Description("R")]
        R,
        [Description("NC-17")]
        NC17
    }

    [Table("movies")]
    public class Movie : TimestampedEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("runtime_mins")]
        public int RuntimeMins { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        public ICollection<Screening> Screenings { get; set; }
    }
}
