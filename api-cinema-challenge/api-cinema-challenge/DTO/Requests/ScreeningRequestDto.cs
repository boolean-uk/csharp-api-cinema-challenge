﻿namespace api_cinema_challenge.DTO.Requests
{
    public class ScreeningRequestDto
    {
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
    }
}
