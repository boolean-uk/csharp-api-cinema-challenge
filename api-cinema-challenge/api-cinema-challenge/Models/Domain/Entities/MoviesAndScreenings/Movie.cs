using api_cinema_challenge.Models.Domain.Interfaces;
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
    public class Movie : ICreatedAndUpdatedTimeStamping
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
        public MovieRating Rating { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        public ICollection<Screening> Screenings { get; set; }
    }
}
