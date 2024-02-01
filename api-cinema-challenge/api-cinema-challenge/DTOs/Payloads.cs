using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace api_cinema_challenge.DTOs
{
    public record CreateCustomerPayload {

        [Required(ErrorMessage = "Name required!")]
        public string Name { get; init; }

        [Required(ErrorMessage = "Email required!")]
        public string Email { get; init; }

        [Required(ErrorMessage = "Phone number required!")]
        public string Phone { get; init; }

        public CreateCustomerPayload(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

    };

    public class CreateScreeningPayload
    {

        [Required(ErrorMessage = "Screen Number Required!")]
        public int screenNumber { get; init; }

        [Required(ErrorMessage = "Capacity Required!")]
        public int capacity { get; init; }

        [Required(ErrorMessage = "Starting Datetime Required!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{YYYY-MM-DD HH:MM:SS}")] // why doesn't it work...
        public DateTime startsAt { get; init; }

        public CreateScreeningPayload(int screen, int cap, DateTime starts )
        {
            screenNumber = screen;
            capacity = cap;
            startsAt = starts;
        }
    };

    public record CreateMoviePayload {


        [Required(ErrorMessage = "Field required!")]
        public string title { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string rating { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string description { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public int runtimeMins { get; init; }

        public CreateMoviePayload(string t, string r, string d, int rtm)
        {
            title = t;
            rating = r;
            description = d;
            runtimeMins = rtm;
        }


    };



    public record UpdateCustomerPayload
    {

        [Required(ErrorMessage = "Name required!")]
        public string name { get; init; }

        [Required(ErrorMessage = "Email required!")]
        public string email { get; init; }

        [Required(ErrorMessage = "Phone number required!")]
        public string phone { get; init; }

        public UpdateCustomerPayload(string n, string e, string p)
        {
            name = n;
            email = e;
            phone = p;
        }

    };

    public record UpdateMoviePayload
    {


        [Required(ErrorMessage = "Field required!")]
        public string title { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string rating { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public string description { get; init; }

        [Required(ErrorMessage = "Field required!")]
        public int runtimeMins { get; init; }

        public UpdateMoviePayload(string t, string r, string d, int rtm)
        {
            title = t;
            rating = r;
            description = d;
            runtimeMins = rtm;
        }

    };

}

