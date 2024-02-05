using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{

    public class Screening
    {

        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ScreenId { get; set; }
        public Screen Screen { get; set; }
        [Column("price_per_seat")]
        public int price { get; set; } = 100;
    public DateTime StartsAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }


    public List<Ticket> Tickets { get; set; }
}
}
