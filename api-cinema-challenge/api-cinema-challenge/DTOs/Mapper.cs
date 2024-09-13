using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTOs
{
    public static class Mapper
    {
        public static ResponseCustomerDTO MapToDTO(Customer customer)
        {
            ResponseCustomerDTO responseCustomer = new ResponseCustomerDTO();
            responseCustomer.Id = customer.Id;
            responseCustomer.Name = customer.Name;
            responseCustomer.Email = customer.Email;
            responseCustomer.Phone = customer.Phone;
            responseCustomer.CreatedAt = customer.CreatedAt;
            responseCustomer.UpdatedAt = customer.UpdatedAt;

            foreach (Ticket t in customer.Tickets)
            {
                ResponseTicketDTOCustomerLess responseTicket = new ResponseTicketDTOCustomerLess();
                responseTicket.Id = t.Id;
                responseTicket.NumSeats = t.NumSeats;
                responseTicket.ScreenNumber = t.Screening.ScreenNumber;
                responseTicket.ScreeningStartsAt = t.Screening.StartsAt;
                responseTicket.MovieTitle = t.Screening.Movie.Title;
                responseTicket.CreatedAt = t.CreatedAt;
                responseTicket.UpdatedAt = t.UpdatedAt;

                responseCustomer.Tickets.Add(responseTicket);
            }

            return responseCustomer;
        }

        public static ResponseMovieDTO MapToDTO(Movie movie)
        {
            ResponseMovieDTO responseMovie = new ResponseMovieDTO();
            responseMovie.Id = movie.Id;
            responseMovie.Title = movie.Title;
            responseMovie.Rating = movie.Rating;
            responseMovie.Description = movie.Description;
            responseMovie.RuntimeMins = movie.RuntimeMins;
            responseMovie.CreatedAt = movie.CreatedAt;
            responseMovie.UpdatedAt = movie.UpdatedAt;

            foreach (Screening s in movie.Screenings)
            {
                ResponseScreeningDTOMovieLess responseSreening = new ResponseScreeningDTOMovieLess();
                responseSreening.Id = s.Id;
                responseSreening.ScreenNumber = s.ScreenNumber;
                responseSreening.Capacity = s.Capacity;
                responseSreening.StartsAt = s.StartsAt;
                responseSreening.CreatedAt = s.CreatedAt;
                responseSreening.UpdatedAt = s.UpdatedAt;

                responseMovie.Screenings.Add(responseSreening);
            }

            return responseMovie;
        }

        public static ResponseScreeningDTO MapToDTO(Screening screening)
        {
            ResponseScreeningDTO responseScreening = new ResponseScreeningDTO();
            responseScreening.Id = screening.Id;
            responseScreening.ScreenNumber = screening.ScreenNumber;
            responseScreening.Capacity = screening.Capacity;
            responseScreening.MovieId = screening.MovieId;
            responseScreening.MovieTitle = screening.Movie.Title;
            responseScreening.StartsAt = screening.StartsAt;
            responseScreening.CreatedAt = screening.CreatedAt;
            responseScreening.UpdatedAt = screening.UpdatedAt;
            responseScreening.NumOfTicketsSold = screening.Tickets.Count;

            return responseScreening;
        }
    }
}
