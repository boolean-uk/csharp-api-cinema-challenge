using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace api_cinema_challenge.Models;

public class Ticket : ICinemaEntities
{

    public int Id {get;set;}
    public int NumSeats {get;set;}
    public int PersonId {get;set;}
    public int ScreenMovieId {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    [NotMapped]
    public virtual Customer Customer {get;set;}
    [NotMapped]
    public virtual ScreenMovie ScreenMovie {get;set;}

    public void Update(ICinemaEntities entity)
    {
        throw new NotImplementedException();
    }
}
