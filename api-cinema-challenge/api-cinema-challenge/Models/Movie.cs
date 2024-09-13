using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("Title")]
        public string Title { get; set; }

        [Column("Rating")]
        public string Rating { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("RunTimeMins")]
        public int RunTimeMins { get; set; }

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; }

        [Column("Updated A")]
        public DateTime UpdatedAt { get; set; }

        public Movie(string title, string rating, string description, int runTimeMins)
        {
            Title = title;
            Rating = rating;
            Description = description;
            RunTimeMins = runTimeMins;
            CreatedAt = DateTime.Now.ToUniversalTime();
            UpdatedAt = DateTime.Now.ToUniversalTime();
        }
    }
}
