using api_cinema_challenge.Models.Base;
using api_cinema_challenge.User_Requests;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screening")]
    public class Screening : ModelBase
    {
        [Key, Column("id")]
        public int Id { get; set; }
        [Required]
        public int ScreenNumber { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public DateTime StartsAt { get; set; }

        [ForeignKey(nameof(Movie)), Column("fk_id_movie")]
        public int FK_Id_Movie { get; set; }

        public Movie Movie;
        public List<Ticket> Tickets;


        public Screening() { }
        public Screening(ScreeningRequest request)
        {
            if (request == default(ScreeningRequest)) return;

            ScreenNumber = request.ScreenNumber;
            Capacity = request.Capacity;
            StartsAt = request.StartsAt;
        }
    }
}
