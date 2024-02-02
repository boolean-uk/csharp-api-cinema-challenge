﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace api_cinema_challenge.Models
{
    public record NewScreening(int ScreenNr, int Capacity, DateTime StartsAt);
    [Table("screenings")]
    public class Screenings
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("screen_nr")]
        public int ScreenNr { get; set; }
        [Column("capacity")]
        public int Capacity { get; set; }
        [Column("starts_at")]
        public DateTime StartsAt { get; set; }
        [Column("movies_id")]
        public int MoviesId { get; set; }
        //[Column("movie")]
        public virtual Movies Movies { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Screenings()
        {
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
