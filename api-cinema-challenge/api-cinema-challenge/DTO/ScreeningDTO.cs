using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace api_cinema_challenge.DTO
{
    public class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public string StartsAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }

        public ScreeningDTO(Screening model)
        {
            Id = model.Id;
            ScreenNumber = model.ScreenId;
            Capacity = model.Capacity;
            StartsAt = model.StartsAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
            CreatedAt = model.CreatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
            UpdatedAt = model.UpdatedAt.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:ss");
        }
    }
}
