﻿namespace api_cinema_challenge.Models.Posts
{
    public class MoviePost
    {
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int Runtime { get; set; }
        public ICollection<ScreeningPost>? Screenings { get; set; }
    }
}