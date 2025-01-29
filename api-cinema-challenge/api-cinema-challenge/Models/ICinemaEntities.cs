using System;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace api_cinema_challenge.Models;

public interface ICinemaEntities
{
    public int Id {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}

    public void Update(ICinemaEntities entity);
}
