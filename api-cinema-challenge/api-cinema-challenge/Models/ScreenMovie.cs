using System;
using System.ComponentModel.DataAnnotations.Schema;
using api_cinema_challenge.DTOs;

namespace api_cinema_challenge.Models;

//Refers to a screening
public class ScreenMovie : ICinemaEntities
{
    public int Id {get;set;}
    public int AvailableSeats {get;set;}
    public int ScreenId {get;set;}
    public int MovieId {get;set;}
    public DateTime StartsAt {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}

    [NotMapped]
    public virtual Screen Screen {get;set;}
    [NotMapped]
    public virtual Movie Movie {get;set;}
    [NotMapped]
    public virtual ICollection<Ticket> Tickets {get;set;}

    public void Update(ICinemaEntities entity)
    {
        if (entity is ScreenMovie e)
        {
            if (e.AvailableSeats != null)
            {
                AvailableSeats = e.AvailableSeats;
            }
            

        }
    }
}
