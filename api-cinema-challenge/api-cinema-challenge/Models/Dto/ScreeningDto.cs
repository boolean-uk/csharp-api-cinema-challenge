﻿namespace api_cinema_challenge.Models.Dto
{
    public class ScreeningDto
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public MovieDto Movie { get; set; }
       
    }
}