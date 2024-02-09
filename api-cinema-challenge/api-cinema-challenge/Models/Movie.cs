    using System.ComponentModel.DataAnnotations.Schema;
    using Newtonsoft.Json;

    namespace api_cinema_challenge.Models
{
    [Table("Movie")]
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

        [JsonIgnore]
        public List<Screening> Screenings { get; set; }
    }
}
