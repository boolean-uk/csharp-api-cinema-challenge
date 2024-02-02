using api_cinema_challenge.Models;

namespace api_cinema_challenge.DTO
{

    public class UserDataDTO
    {
        public string status { get; set; }
        public User data { get; set; }

        public UserDataDTO(User user, string status) { 
            data = user;
            this.status = status;
        }

    }


    public class UserListDataDTO
    {
        public string status { get; set; }
        public List<UserAllDetailsDTO> data { get; set; }
        public UserListDataDTO(List<UserAllDetailsDTO> user_data, string status)
        {
            data = user_data;
            this.status = status;
        }
  
    }


    public class MovieDataDTO
    {
        public string status { get; set; }
        public MovieAllDetailsDTO data { get; set; }    
        public MovieDataDTO(Movie movie, string status) {
            data = new MovieAllDetailsDTO(movie);
            this.status = status;
        }
    }


    public class MovieListDataDTO
    {
        public string status { get; set; }
        public List<MovieAllDetailsDTO> data { get; set; }

        public MovieListDataDTO(List<MovieAllDetailsDTO> movie_data, string status)
        {
            data = movie_data;
            this.status = status;
        }
    }


    public class ScreeningDataDTO
    {
        public string status { get; set; }
        public ScreeningAllDetailsDTO data { get; set; }

        public ScreeningDataDTO(Screening screening, string status)
        {
            data = new ScreeningAllDetailsDTO(screening);
            this.status = status;
        }
    }

    public class TicketDataDTO
    {
        string status { get; set; }
        public TicketDTO data { get; set; }
        public TicketDataDTO(Ticket ticket_data, string status)
        {
            data = new TicketDTO(ticket_data);
        }
    }
    
}
