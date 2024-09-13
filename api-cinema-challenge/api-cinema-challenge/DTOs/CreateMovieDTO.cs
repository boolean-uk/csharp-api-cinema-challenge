namespace api_cinema_challenge.DTOs
{
    public class CreateMovieDTO
    {

        public string name { get; set; }

        public int rating { get; set; }

        public string description { get; set; }

        public int runTimemins { get; set; }

        public List<GetScreeningDTO> screenings { get; set; }

    }
}
