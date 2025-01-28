using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movies")]
    public class Movies
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("raiting")]
        public string Raiting { get; set; }
        public string Description { get; set; }
        [Column("runetime_mins")]
        public int RuntimeMins { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
