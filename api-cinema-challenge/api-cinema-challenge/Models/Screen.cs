using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

public class Screen : ICinemaEntities
{
    public int Id {get;set;}
    public int ScreenNumber {get;set;}
    public int Capacity {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    [NotMapped]
    public virtual ICollection<ScreenMovie> ScreenMovies {get;set;}

    public void Update(ICinemaEntities entity)
    {
        throw new NotImplementedException();
    }
}
