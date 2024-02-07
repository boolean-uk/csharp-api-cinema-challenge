﻿namespace api_cinema_challenge.Models.DTOS.movieDTOS
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public MovieDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            string datePattern = "yyyy-MM-ddTHH:mm:ss";
            CreatedAt = movie.CreatedAt.ToString(datePattern);
            UpdatedAt = movie.UpdatedAt.ToString(datePattern);
        }
    }


}
