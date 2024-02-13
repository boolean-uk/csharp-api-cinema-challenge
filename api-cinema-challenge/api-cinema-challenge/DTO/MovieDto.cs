using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.DTO
{
    public class MovieDto
    {
        [Column("title")]
        public string Title { get; set; }
        [Column("rating")]
        public string Rating { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("runtimeMins")]
        public int RuntimeMins { get; set; }
        [Column("screenings")]
        public List<ScreeningDto> Screenings { get; set; }
    }
}
