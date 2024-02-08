namespace api_cinema_challenge.Models.MovieModels
{
    public class OutputMovie
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Rating { get; set; }

        public string Runtime { get; set; }
    }
}
