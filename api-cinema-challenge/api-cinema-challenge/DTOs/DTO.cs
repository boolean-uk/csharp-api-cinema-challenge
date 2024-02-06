using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{
    // Customer
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public CustomerDTO(Customer customer)
        {
            CustomerId = customer.Id;
            Name = customer.Name;
        }
    }

    public class CustomerResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public CustomerResponseDTO(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Email = customer.Email;
            Phone = customer.Phone;
            CreatedAt = customer.CreatedAt;
            UpdatedAt = customer.UpdatedAt;
        }
    }

    // Movie
    public class MovieDTO
    {
        private Movie movie;

        public MovieDTO(Movie movie)
        {
            this.movie = movie;
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
    }

    public class MovieResponseDTO
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public MovieResponseDTO(Movie movie)
        {
            MovieId = movie.Id;
            Title = movie.Title;
            Rating = movie.Rating;
            Description = movie.Description;
            RuntimeMins = movie.RuntimeMins;
            CreatedAt = movie.CreatedAt;
            UpdatedAt = movie.UpdatedAt;
        }
    }


    // Screening
    public class ScreeningResponseDTO
    {
        public int Id { get; set; }
        public int ScreenNumber { get; set; }
        public int Capacity { get; set; }
        public DateTime StartsAt { get; set; }

        public ScreeningResponseDTO(Screening screening)
        {
            Id = screening.Id;
            ScreenNumber = screening.ScreenNumber;
            Capacity = screening.Capacity;
            StartsAt = screening.StartsAt;
        }
    }
    // Ticket
    public class TicketDto
    {
        public int Id { get; set; }
        public int NumSeats { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class CreateTicketPayload
    {
        public int CustomerId { get; set; }
        public int ScreeningId { get; set; }
        public int NumSeats { get; set; }
    }

    public class GetAllTicketsResponseDto
    {
        public string Status { get; set; }
        public List<TicketDto> Data { get; set; }
    }
}
