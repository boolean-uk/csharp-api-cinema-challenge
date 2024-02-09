using api_cinema_challenge.Models.DTOs;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models
{
    [Table("screenings")]
    public class Screening
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("screen_number")]
        public int ScreenNumber { get; set;}
        [Column("capacity")]
        public int Capacity { get; set;}
        [Column("available_seats")]
        public int AvailableSeats { get; set; }
        [Column("movie_id")]
        public int MovieId { get; set;}
        public Movie? Movie { get; set;}
        [Column("starts_at")]
        public DateTime StartsAt { get; set;} = DateTime.UtcNow;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

        public static PayLoad<ScreeningDTO> ToDTO(Screening screening)
        {
            var screeningDTO = new ScreeningDTO
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAt
            };

            return new PayLoad<ScreeningDTO> { Data = screeningDTO };
        }

        public static PayLoad<List<ScreeningDTO>> ToDTO(ICollection<Screening> screenings)
        {
            List<ScreeningDTO> screeningsDTO = new List<ScreeningDTO>();
            foreach (Screening screening in screenings)
            {
                screeningsDTO.Add(new ScreeningDTO
                {
                    Id = screening.Id,
                    ScreenNumber = screening.ScreenNumber,
                    Capacity = screening.Capacity,
                    StartsAt = screening.StartsAt,
                    CreatedAt = screening.CreatedAt,
                    UpdatedAt = screening.UpdatedAt
                });
            }

            return new PayLoad<List<ScreeningDTO>> { Data = screeningsDTO.OrderBy(x => x.Id).ToList() };
        }
    }
}
