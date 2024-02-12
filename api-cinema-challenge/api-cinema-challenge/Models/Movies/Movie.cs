using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models.Movies
{
    [Table("movies")]
    public class Movie
    {
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
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public Movie Update(MovieInput newData)
        {
            Title = newData.Title;
            Rating = newData.Rating;
            Description = newData.Description;
            RuntimeMins = newData.RuntimeMins;
            UpdatedAt = DateTime.UtcNow;
            return this;
        }
    }
}
