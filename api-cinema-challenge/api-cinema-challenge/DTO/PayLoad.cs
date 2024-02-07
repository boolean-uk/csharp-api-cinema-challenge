

using api_cinema_challenge.Models;
using System.ComponentModel.DataAnnotations;

namespace api_cinema_challenge.DTO
{
    public record CustomerPayload
    {

        [Required(ErrorMessage = "Name required!")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Email required!")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Phone number required!")]
        public string Phone { get; init; }

        public CustomerPayload(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

    };


    public record ScreeningPayload 
    {
        public int ScreenNumber { get; init; }
        public int Capacity { get; init; }
        public DateTime StartAt { get; init; } = DateTime.UtcNow;

        public ScreeningPayload(int  screenNumber, int capacity, DateTime startAt)
        {
            ScreenNumber = screenNumber;
            Capacity = capacity;
            StartAt = startAt;
        }



    };

    public record MoviePayload
    {
        public string Title { get; init; }
        public string Rating { get; init; }
        public string Description { get; init; }
        public int runTime { get; init; }

        public MoviePayload(string title, string rating, string description, int runtime)
        {
            Title = title;
            Rating = rating;
            Description = description;
            runTime = runtime;

        }

    }
}
