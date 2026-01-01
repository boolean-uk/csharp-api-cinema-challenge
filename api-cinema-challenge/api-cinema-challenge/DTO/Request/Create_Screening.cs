using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO.Request
{
    public class Create_Screening : IDTO_Request_create<Create_Screening, Screening>
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }

        public static Screening create(Create_Screening dto, params object[] pathargs)
        {
            return new Screening
            {
                MovieId = (int)pathargs[0],
                ScreenNumber = dto.ScreenNumber,
                Capacity =     dto.Capacity,
                StartsAt =     dto.StartsAt
            };
        }
        
        
    }
}
