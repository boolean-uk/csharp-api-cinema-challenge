using api_cinema_challenge.Data;
using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using api_cinema_challenge.Payloads;
using Microsoft.EntityFrameworkCore;
using System.Globalization;



namespace api_cinema_challenge.Repository
{
    public class Repository : IRepository
    {
        private CinemaContext _db;
        public Repository(CinemaContext db)
        {
            _db = db;
        }
        public async Task<ResponseDTO<CustomerDTO>> CreateCustomer(CustomerPayload payload)
        {
            if(payload.Name == null || payload.Name == "" ||
                payload.Email == null || payload.Email == "" ||
                payload.Phone == null || payload.Email == "")
            {
                throw new Exception("Invalid input!");
            }
            Customer customer = new Customer(payload.Name, payload.Email, payload.Phone);
            _db.Customers.Add(customer);
            await _db.SaveChangesAsync();

            ResponseDTO<CustomerDTO> result = new ResponseDTO<CustomerDTO>("success", MakeCustomerDTO(customer));
            return result;
        }

        private CustomerDTO MakeCustomerDTO(Customer customer)
        {
            CustomerDTO customerDTO = new CustomerDTO();
            customerDTO.Name = customer.Name;
            customerDTO.Email = customer.Email;
            customerDTO.Phone = customer.Phone;
            customerDTO.UpdatedAt = customer.UpdatedAt;
            customerDTO.CreatedAt = customer.CreatedAt;
            customerDTO.Id = customer.Id;
            return customerDTO;
        }

        public async Task<ResponseDTO<MovieDTO>> CreateMovie(MoviePayload payload)
        {
            if (payload.Title == null || payload.Title == "" ||
              payload.Rating == null || payload.Rating == "" ||
              payload.Description == null || payload.Description == ""
              || payload.RunTimeMins < 0)
            {
                throw new Exception("Invalid input!");
            }
            Movie movie = new Movie(payload.Title, payload.Rating, payload.Description, payload.RunTimeMins);
            _db.Movies.Add(movie);

            await _db.SaveChangesAsync();

            foreach (var screenLoad in payload.Screens)
            {
                try
                {
                    await CreateScreening(movie.Id, screenLoad);
                }
                catch 
                {
                    throw new Exception("Unable to create screening because of invalid data input!");
                }
            }


            await _db.SaveChangesAsync();

            ResponseDTO<MovieDTO> result = new ResponseDTO<MovieDTO>("success", MakeMovieDTO(movie));
            return result;
        }

        private MovieDTO MakeMovieDTO(Movie movie)
        {
            MovieDTO dto = new MovieDTO();
            dto.Title = movie.Title;
            dto.Rating = movie.Rating;
            dto.Description = movie.Description;
            dto.Id = movie.Id;
            dto.CreatedAt = movie.CreatedAt;
            dto.UpdatedAt = movie.UpdatedAt;
            dto.RunTimeMins = movie.RunTimeMins;
            return dto;
        }

        public async Task<ResponseDTO<ScreeningDTO>> CreateScreening(int movieId, ScreeningPayload payload)
        {
            if(payload.ScreenNumber < 0 || payload.Capacity < 1)
            {
                throw new Exception("Invalid input");
            }
            var movie = _db.Movies.FirstOrDefault(x => x.Id == movieId);
            if(movie == null)
            {
                throw new Exception("Movie does not exist!");
            }
            CultureInfo culture = CultureInfo.InvariantCulture;
           
            Screening screening = new Screening(movieId, payload.ScreenNumber, payload.Capacity, DateTime.ParseExact(payload.StartsAt, "yyyy-MM-dd HH:mm:ss", culture).ToUniversalTime());
            _db.Screenings.Add(screening);
            await _db.SaveChangesAsync();

            ResponseDTO<ScreeningDTO> result = new ResponseDTO<ScreeningDTO>("success", MakeScreeningDTO(screening));
            return result;
        }

        private ScreeningDTO MakeScreeningDTO(Screening screening)
        {
            ScreeningDTO dto = new ScreeningDTO();
            dto.Capacity = screening.Capacity;
            dto.UpdatedAt = screening.UpdatedAt;
            dto.CreatedAt = screening.CreatedAt;
            dto.startsAt = screening.startsAt;
            dto.ScreenNumber = screening.ScreenNumber;
            dto.Id = screening.Id;

           return dto;
        }

        public async Task<ResponseDTO<CustomerDTO>> DeleteCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == customerId);
            if(customer == null)
            {
                throw new Exception("Customer does not exist");
            }
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            ResponseDTO<CustomerDTO> result = new ResponseDTO<CustomerDTO>("success", MakeCustomerDTO(customer));
            return result;
        }

        public async Task<ResponseDTO<MovieDTO>> DeleteMovie(int movieId)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                throw new Exception("Movie does not exist");
            }
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            ResponseDTO<MovieDTO> result = new ResponseDTO<MovieDTO>("success", MakeMovieDTO(movie));
            return result;
        }

        public async Task<ResponseDTOs<CustomerDTO>> GetCustomers()
        {
            var customers = await _db.Customers.ToListAsync();
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                customerDTOs.Add(MakeCustomerDTO(customer));
            }
            ResponseDTOs<CustomerDTO> result = new ResponseDTOs<CustomerDTO>("success", customerDTOs);
            return result;
        }

        public async Task<ResponseDTOs<MovieDTO>> GetMovies()
        {
            var movies = await _db.Movies.ToListAsync();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                movieDTOs.Add(MakeMovieDTO(movie));
            }
            ResponseDTOs<MovieDTO> result = new ResponseDTOs<MovieDTO>("success", movieDTOs);
            return result;
        }

        public async Task<ResponseDTOs<ScreeningDTO>> GetScreenings(int movieId)
        {
            var screenings = await _db.Screenings.Where(x => x.MovieId == movieId).ToListAsync();
            List<ScreeningDTO> screeningDTOs = new List<ScreeningDTO>();
            foreach (var s in screenings)
            {
                if(s.MovieId == movieId)
                {
                    screeningDTOs.Add(MakeScreeningDTO(s));
                }
            }
            ResponseDTOs<ScreeningDTO> result = new ResponseDTOs<ScreeningDTO>("success", screeningDTOs);
            return result;
        }

        public async Task<ResponseDTO<CustomerDTO>> UpdateCustomer(int customerId, CustomerPayload payload)
        {
            if (payload.Name == null || payload.Name == "" ||
                payload.Email == null || payload.Email == "" ||
                payload.Phone == null || payload.Email == "")
            {
                throw new Exception("Invalid input!");
            }
            var customer = _db.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer == null)
            {
                throw new Exception("Customer does not exist");
            }
            customer.Name = payload.Name;
            customer.Phone = payload.Phone;
            customer.Email = payload.Email;
            customer.UpdatedAt = DateTime.Now.ToUniversalTime();

            await _db.SaveChangesAsync();

            ResponseDTO<CustomerDTO> result = new ResponseDTO<CustomerDTO>("success", MakeCustomerDTO(customer));
            return result;
        }

        public async Task<ResponseDTO<MovieDTO>> UpdateMovie(int movieId, MoviePayload payload)
        {
            if (payload.Title == null || payload.Title == "" ||
              payload.Rating == null || payload.Rating == "" ||
              payload.Description == null || payload.Description == ""
              || payload.RunTimeMins < 0)
            {
                throw new Exception("Invalid input!");
            }
            var movie = _db.Movies.FirstOrDefault(x => x.Id == movieId);
            if(movie == null)
            {
                throw new Exception("Movie does not exist");
            }
            movie.Title = payload.Title;
            movie.Rating = payload.Rating;
            movie.Description = payload.Description;
            movie.RunTimeMins = payload.RunTimeMins;
            movie.UpdatedAt = DateTime.Now.ToUniversalTime();

            await _db.SaveChangesAsync();

            ResponseDTO<MovieDTO> result = new ResponseDTO<MovieDTO>("success", MakeMovieDTO(movie));
            return result;
        }

        public async Task<ResponseDTO<TicketDTO>> BookTicket(int numSeats, int customerId, int screeningId)
        {
            if(numSeats < 1) // need at least 1 tickets
            {
                throw new Exception("At least 1 ticket must be booked");
            }
            Ticket ticket = new Ticket(numSeats, customerId, screeningId);
            _db.Tickets.Add(ticket);
            await _db.SaveChangesAsync();

            ResponseDTO<TicketDTO> result = new ResponseDTO<TicketDTO>("success", MakeTicketDTO(ticket));
            return result;
        }

        private TicketDTO MakeTicketDTO(Ticket ticket)
        {
            TicketDTO dto = new TicketDTO();
            dto.Id = ticket.Id;
            dto.UpdatedAt = ticket.UpdatedAt;
            dto.CreatedAt = ticket.CreatedAt;
            dto.NumSeats = ticket.NumberOfSeats;

            return dto;
        }

        public async Task<ResponseDTOs<TicketDTO>> GetTickets(int customerId, int screeningId)
        {
            var tickets = await _db.Tickets.Where(ci => ci.CustomerId == customerId).Where(si => si.ScreeningId == screeningId).ToListAsync();
            List<TicketDTO> movieDTOs = new List<TicketDTO>();
            foreach (var ticket in tickets)
            {
                movieDTOs.Add(MakeTicketDTO(ticket));
            }
            ResponseDTOs<TicketDTO> result = new ResponseDTOs<TicketDTO>("success", movieDTOs);
            return result;
        }
    }
}
