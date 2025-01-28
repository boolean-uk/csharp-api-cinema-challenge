using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTO.Response
{
    public class Get_Screening : DTO_Response<Get_Screening, Screenings>
    {
        public int Id { get; set; }
        //public int MovieId { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();


        public override void Initialize(Screenings model)
        {
            Id = model.Id;
            //MovieId = model.MovieId;
            ScreenNumber = model.ScreenNumber;
            Capacity = model.Capacity;
            StartsAt = model.StartsAt;
            CreatedAt = model.CreatedAt;
            UpdatedAt = model.UpdatedAt;

        }
    }
}
