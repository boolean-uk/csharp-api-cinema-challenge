using System.Collections.Generic;
using System.Linq;

namespace api_cinema_challenge.Models.DTOs
{
    public class ScreeningForScreenDTO
    {
        public int ScreeningId { get; set; }
        public string MovieName { get; set; }
        public DateTime StartsAt { get; set; }
    }

    public class ScreenDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfSeats { get; set; }
        public List<ScreeningForScreenDTO> Screenings { get; set; }

        public static ScreenDTO FromScreen(Screen screen)
        {
            return new ScreenDTO
            {
                Id = screen.id,
                Name = screen.name,
                NumberOfSeats = screen.Seats?.Count ?? 0,
                Screenings = screen.Screenings?.Select(s => new ScreeningForScreenDTO
                {
                    ScreeningId = s.Id,
                    MovieName = s.Screen?.Screenings?.FirstOrDefault(x => x.Id == s.Id)?.Movie?.Title,  StartsAt = s.StartsAt
                }).ToList() ?? new List<ScreeningForScreenDTO>()
            };
        }

        public static List<ScreenDTO> FromListOfScreens(List<Screen> screens)
        {
            List<ScreenDTO> screeningDTOs = new List<ScreenDTO>();
            foreach (Screen screen in screens)
            {
                screeningDTOs.Add(ScreenDTO.FromScreen(screen));
            }
            return screeningDTOs;

        }

    }
}