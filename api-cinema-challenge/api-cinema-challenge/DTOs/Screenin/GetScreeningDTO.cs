﻿namespace api_cinema_challenge.DTOs.Screenin
{
    public class GetScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public int NumOfTicketsSold { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
