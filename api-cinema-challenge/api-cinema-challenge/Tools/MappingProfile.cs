using api_cinema_challenge.DTO;
using api_cinema_challenge.Models;
using AutoMapper;

namespace api_cinema_challenge.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerView>();

            CreateMap<Movie, MovieView>();
            CreateMap<Movie, MovieSimple>();

            CreateMap<Screen, ScreenView>();
            CreateMap<Screen, ScreenInternal>();
            CreateMap<Screen, ScreenSimple>();
            CreateMap<Screen, ScreenName>();

            CreateMap<Screening, ScreeningView>()
                .ForMember(dst => dst.AvailableSeats, opt => opt.MapFrom(src => src.Screen.Seats.Except(src.Tickets.Select(t => t.Seat))));
            CreateMap<Screening, ScreeningViewSeatCount>()
                .ForMember(dst => dst.AvailableSeats, opt => opt.MapFrom(src => src.Screen.Seats.Except(src.Tickets.Select(t => t.Seat)).Count()));
            CreateMap<Screening, ScreeningScreen>();
            CreateMap<Screening, ScreeningSimple>();

            CreateMap<Seat, SeatView>()
                .ForMember(dst => dst.SeatType, opt => opt.MapFrom(src => src.SeatType.ToString()));
            CreateMap<Seat, SeatInternal>()
                .ForMember(dst => dst.SeatType, opt => opt.MapFrom(src => src.SeatType.ToString()));
            CreateMap<Ticket, TicketView>()
                .ForMember(dst => dst.TicketType, opt => opt.MapFrom(src => src.TicketType.ToString()))
                .ForMember(dst => dst.Screen, opt => opt.MapFrom(src => src.Screening.Screen))
                .ForMember(dst => dst.Movie, opt => opt.MapFrom(src => src.Screening.Movie))
                .ForMember(dst => dst.Price, opt => opt.MapFrom(src => (int)src.TicketType));
        }
    }
}
