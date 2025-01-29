using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_cinema_challenge.Models;

public class Customer : ICinemaEntities
{
    public int Id {get;set;}
    public string Email {get;set;}
    public string Name {get;set;}
    public string Phone {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}
    [NotMapped]
    public virtual ICollection<Ticket> Tickets {get;set;}

    public void Update(ICinemaEntities entity)
    {
        if (entity is Customer e)
        {
            if (e.Name != "")
            {
                Name = e.Name;
            }
            if(e.Email != "")
            {
                Email = e.Email;
            }
            if (e.Phone != "")
            {
                Phone = e.Phone;
            }

        }
    }
}
