namespace api_cinema_challenge.DTOs
{
    public class ResponseMovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<ResponseScreeningDTOMovieLess> Screenings { get; set; } = new List<ResponseScreeningDTOMovieLess>();
    }

    public class PostMovieDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public List<PostScreeningDTOMovieLess> Screenings { get; set; }
    }

    public class PutMovieDTO
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }
}
