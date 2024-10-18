namespace api_cinema_challenge.DTOs
{
    public class GetMovieDTO
    {

       public string title { get; set; }

        public int rating { get; set; }

        public string description { get; set; }

        public int runTimemins { get; set; }

        public DateTime createdAt { get; set; }    

        public DateTime updatedAt { get; set; }

        public List<GetScreeningDTO>  screenings { get; set; }
    }
}
