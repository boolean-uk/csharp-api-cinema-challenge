namespace api_cinema_challenge.Models
{
    public class MoviePayload
    {
        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RunttimeMins { get; set; }

        public string CheckPayload()
        {
            if (string.IsNullOrWhiteSpace(Title)) { return "Title is required"; }
            if (string.IsNullOrWhiteSpace(Rating)) { return "Rating is required"; }
            if (string.IsNullOrWhiteSpace(Description)) { return "Description is required"; }
            if (RunttimeMins <= 0) { return "Runtime cant be less than 1min"; }
            return string.Empty;
        }
    }


}
