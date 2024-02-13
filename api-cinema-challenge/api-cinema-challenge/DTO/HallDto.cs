using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    public class HallDto
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public HallDto(Hall hall)
        {
            Name = hall.HallName;
            Desc = hall.HallDesc;
        }

        public HallDto()
        {
            
        }
    }
}
