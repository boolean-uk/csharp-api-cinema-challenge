using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    class CustomersOutput
    {
        public string status { get; set; }

        public List<CustomerDTO> data { get; set; }


        public CustomersOutput(List<CustomerDTO> customersDTO)
        {
            status = "success";
            data = customersDTO;
        }

    }
    class CustomerOutput
    {
        public string status { get; set; }

        public CustomerDTO data { get; set; }

        public CustomerOutput(CustomerDTO customerDTO)
        {
            status = "success";
            data = customerDTO;
        }

    }
    class CustomerDTO
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

        public CustomerDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            createdAt = customer.CreatedAt;
            updatedAt = customer.UpdatedAt;
        }
    }
    class MovieDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int runTimeMins { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public MovieDTO(Movie movie)
        {
            Id = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            runTimeMins = movie.RunTimeMins;
            createdAt = movie.CreatedAt;
            updatedAt = movie.UpdatedAt;
        }
    }
    class MoviesOutput
    {
        public string status { get; set; }

        public List<MovieDTO> data { get; set; }


        public MoviesOutput(List<MovieDTO> moviesDTO)
        {
            status = "success";
            data = moviesDTO;
        }

    }
    class MovieOutput
    {
        public string status { get; set; }

        public MovieDTO data { get; set; }

        public MovieOutput(MovieDTO movieDTO)
        {
            status = "success";
            data = movieDTO;
        }

    }
    class ScreeningDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ScreeningDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
            CreatedAt = screening.CreatedAt;
            UpdatedAt = screening.UpdatedAt;
        }
    }
    class ScreeningsOutput
    {
        public string status { get; set; }

        public List<ScreeningDTO> data { get; set; }


        public ScreeningsOutput(List<ScreeningDTO> screeningsDTO)
        {
            status = "success";
            data = screeningsDTO;
        }

    }
    class ScreeningOutput
    {
        public string status { get; set; }

        public ScreeningDTO data { get; set; }

        public ScreeningOutput(ScreeningDTO screeningDTO)
        {
            status = "success";
            data = screeningDTO;
        }

    }
    class TicketDTO
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public TicketDTO(Ticket ticket)
        {
            Id = ticket.Id;
            NumSeats = ticket.NumSeats;
            CreatedAt = ticket.CreatedAt;
            UpdatedAt = ticket.UpdatedAt;
        }
    }
    class TicketsOutput
    {
        public string status { get; set; }

        public List<TicketDTO> data { get; set; }


        public TicketsOutput(List<TicketDTO> ticketsDTO)
        {
            status = "success";
            data = ticketsDTO;
        }

    }
    class TicketOutput
    {
        public string status { get; set; }

        public TicketDTO data { get; set; }

        public TicketOutput(TicketDTO ticketDTO)
        {
            status = "success";
            data = ticketDTO;
        }

    }



}
