using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class ScreeningResponseDTO
    {
        public string Status { get; set; }
        public DataScreeningDTO Datas { get; set; }

        public ScreeningResponseDTO(Screening screening) 
        {
            Status = "Success";
            Datas = new DataScreeningDTO(screening);
        }

        public static List<ScreeningResponseDTO> FromRepository(IEnumerable<Screening> screenings)
        {
            var results = new List<ScreeningResponseDTO>();
            foreach (var screening in screenings)
                results.Add(new ScreeningResponseDTO(screening));
            return results;
        }

        public static ScreeningResponseDTO FromARepository(Screening screening)
        {
            ScreeningResponseDTO result = new ScreeningResponseDTO(screening);
            return result;
        }
    }
}
