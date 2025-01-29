using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

public class Movie : ICinemaEntities
{
    public int Id {get;set;}
    public string Title {get;set;}
    public string Rating {get;set;}
    public string Description {get;set;}
    public int RuntimeMins {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    [NotMapped]
    public virtual ICollection<ScreenMovie> ScreenMovies {get;set;}

    public void Update(ICinemaEntities entity)
    {
        if (entity is Movie m)
        {
            if (m.Title != "")
            {
                Title = m.Title;
            }
            if(m.Rating != "")
            {
                Rating = m.Rating;
            }
            if (m.Description != "")
            {
                Description = m.Description;
            }
            if (m.RuntimeMins != 0)
            {
                RuntimeMins = m.RuntimeMins;
            }

        }
    }
}
