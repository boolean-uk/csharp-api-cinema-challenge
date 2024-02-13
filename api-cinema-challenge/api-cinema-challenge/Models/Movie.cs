using api_cinema_challenge.Models.Base;
using api_cinema_challenge.User_Requests;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("movie")]
    public class Movie : ModelBase
    {
        [Key, Required, Column("id")]
        public int Id { get; internal set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int RuntimeMins { get; set; }

        public List<Screening> Screenings { get; set; }


        public Movie() { }
        public Movie(MovieRequest movieRequest) {
            if (movieRequest == default(MovieRequest)) return;

            Title = movieRequest.Title;
            Rating = movieRequest.Rating;
            Description = movieRequest.Description;
            RuntimeMins = movieRequest.RuntimeMins;
        }
    }
}
