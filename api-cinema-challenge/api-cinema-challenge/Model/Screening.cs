
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Model {

    [Table("screenings")]
    public class Screening {
        [Column("Id")]
        public int Id {get; set;}
        [Column("screen_number")]
        public int ScreenNumber {get; set;}
        [Column("capacity")]
        public int Capacity {get; set;}
        [Column("starts_at")]
        public DateTime StartsAt {get; set;}
        [Column("created_at")]
        public DateTime EndsAt {get; set;}
        [Column("ends_at")]
        public DateTime CreatedAt {get; set;}
        [Column("updated_at")]
        public DateTime UpdatedAt {get; set;}
        [Column("movie_id")]
        public int MovieId {get; set;}
        public Movie Movie {get; set;} = null!;

        public ICollection<Ticket> Tickets {get; set;} = [];

    }
}