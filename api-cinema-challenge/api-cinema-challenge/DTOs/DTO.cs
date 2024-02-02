using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

namespace api_cinema_challenge.DTOs
{
    class MovieDTO
    {
       
        public string Status { get; set; }
        public object Data { get; set; }
        

        public MovieDTO(Movie movie)
        {
            Status = "success";
            Data = new
            {
                Id = movie.Id,
                Title = movie.Title,
                Rating = movie.Rating,
                Description = movie.Description,
                CreatedAt = movie.CreatedAt,
                UpdatedAt = movie.UpdatedAT
            };
        }

    }


    class CustomerDTO
    {
        public string Status { get; set; }
        public object Data { get; set; }


        public CustomerDTO(Customer customer)
        {
            Status = "success";
            Data = new
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                phone = customer.Phone,
                CreatedAt = customer.CreatedAt,
                UpdatedAt = customer.UpdatedAT
            };
        }
    }

    class ScreeningDTO
    {
        public string Status { get; set; }
        public object Data { get; set; }


        public ScreeningDTO(Screenings screening)
        {
            Status = "success";
            Data = new
            {
                Id = screening.Id,
                ScreenNumber = screening.ScreenNumber,
                Capacity = screening.Capacity,
                StartsAt = screening.StartsAt,
                CreatedAt = screening.CreatedAt,
                UpdatedAt = screening.UpdatedAT
            };
        }
    }



}


