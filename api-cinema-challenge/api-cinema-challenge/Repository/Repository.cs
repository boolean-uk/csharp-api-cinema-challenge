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
        public async Task<CustomerDTO> CreateCustomer(CustomerPayload payload)
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

            return MakeCustomerDTO(customer);
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

        public async Task<MovieDTO> CreateMovie(MoviePayload payload)
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

            return MakeMovieDTO(movie);
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

        public async Task<ScreeningDTO> CreateScreening(int movieId, ScreeningPayload payload)
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

            return MakeScreeningDTO(screening);
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

        public async Task<CustomerDTO> DeleteCustomer(int customerId)
        {
            var customer = _db.Customers.FirstOrDefault(x => x.Id == customerId);
            if(customer == null)
            {
                throw new Exception("Customer does not exist");
            }
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync();

            return MakeCustomerDTO(customer);
        }

        public async Task<MovieDTO> DeleteMovie(int movieId)
        {
            var movie = _db.Movies.FirstOrDefault(x => x.Id == movieId);
            if (movie == null)
            {
                throw new Exception("Movie does not exist");
            }
            _db.Movies.Remove(movie);
            await _db.SaveChangesAsync();

            return MakeMovieDTO(movie);
        }

        public async Task<IEnumerable<CustomerDTO>> GetCustomers()
        {
            var customers = await _db.Customers.ToListAsync();
            List<CustomerDTO> customerDTOs = new List<CustomerDTO>();
            foreach (var customer in customers)
            {
                customerDTOs.Add(MakeCustomerDTO(customer));
            }
            return customerDTOs;
        }

        public async Task<IEnumerable<MovieDTO>> GetMovies()
        {
            var movies = await _db.Movies.ToListAsync();
            List<MovieDTO> movieDTOs = new List<MovieDTO>();
            foreach (var movie in movies)
            {
                movieDTOs.Add(MakeMovieDTO(movie));
            }
            return movieDTOs;
        }

        public async Task<IEnumerable<ScreeningDTO>> GetScreenings(int movieId)
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
            return screeningDTOs;
        }

        public async Task<CustomerDTO> UpdateCustomer(int customerId, CustomerPayload payload)
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
            return MakeCustomerDTO(customer);
        }

        public async Task<MovieDTO> UpdateMovie(int movieId, MoviePayload payload)
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
            return MakeMovieDTO(movie);
        }
    }
}
