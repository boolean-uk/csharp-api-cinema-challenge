using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTO.Interfaces;
using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTO.Response
{
    public class Get_Ticket : DTO_Response<Get_Ticket, Tickets>
    {
        public int Id { get; set; }
        //public int MovieId { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
        public DateTime UpdatedAt { get; set; } = DateTime.Now.ToUniversalTime();


        public override void Initialize(Tickets model)
        {
            Id = model.Id;
            //MovieId = model.MovieId;
            NumSeats = model.NumSeats;
            CreatedAt = model.CreatedAt;
            UpdatedAt = model.UpdatedAt;

        }
    }
}
