using api_cinema_challenge.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace api_cinema_challenge.DTOs
{

    class StatusListDto
    {
        public string status { get; set; }

        public List<Object> data { get; set; } = new List<Object>();

        public StatusListDto(List<Object> dt)
        {
            status = "success";

            foreach(Object o in dt)
            {
                data.Add(o);
            }
        }
    }

    class StatusSingleDto
    {
        public string status { get; set; }

        public Object data { get; set; }

        public StatusSingleDto(Object dt)
        {
            status = "success";
            data = dt;
        }
    }

    // SINGLES
    class MovieDTO {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Rating { get; set; }

        public string Description { get; set; }

        public int RuntimeMins { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public MovieDTO(Movie m)
        {
            Id = m.Id;
            Title = m.Title;
            Rating = m.Rating;
            Description = m.Description;
            RuntimeMins = m.RuntimeMins;
            CreatedAt = m.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            UpdatedAt = m.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }

    }

    class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }

        public int Capacity { get; set; }

        public string StartsAt { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public ScreeningDTO(Screening s)
        {
            Id = s.Id;
            ScreenNumber = s.ScreenNumber;
            Capacity = s.Capacity;
            StartsAt = s.StartsAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            CreatedAt = s.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            UpdatedAt = s.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }
    }


    class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email {get; set; }

        public string Phone {get; set; }

        public string CreatedAt {get ; set; }

        public string UpdatedAt {get; set; }

        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;                                                                        
            CreatedAt = customer.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");  
            UpdatedAt = customer.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }
    }

    class TicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }


        public TicketDTO(Ticket t)
        {
            Id = t.Id;
            NumSeats = t.NumSeats;
            CreatedAt = t.CreatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
            UpdatedAt = t.UpdatedAt.ToString("yyyy-MM-ddTHH':'mm':'ss.fffzzz");
        }
    }
}
