using System;
using System.Collections.Generic;
using System.Linq;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningDTO
    {
        public int ScreeningId { get; set; }
        public string MovieName { get; set; }
        public string ScreenName { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public TimeOnly startTime {  get; set; } 
        public DateOnly Date {  get; set; }


        public static ScreeningDTO FromScreening(Screening screening)
        {
            var totalSeats = screening.Screen?.Seats?.Count ?? 0;
            var bookedSeats = screening.Tickets?.Count(t => t.bookingId.HasValue) ?? 0;
            var availableSeats = totalSeats - bookedSeats;

            return new ScreeningDTO
            {
                ScreeningId = screening.Id,
                MovieName = screening.Movie?.Title,
                ScreenName = screening.Screen.name,
                TotalSeats = totalSeats,
                AvailableSeats = availableSeats,
                startTime = TimeOnly.FromDateTime(screening.StartsAt),
                Date = DateOnly.FromDateTime(screening.StartsAt)


            };
        }

        public static List<ScreeningDTO> FromScreenings(List<Screening> screenings)
        {
            return screenings.Select(FromScreening).ToList();
        }
    }
}
