using api_cinema_challenge.DTOs.TicketDTOs;
using FluentValidation;

namespace api_cinema_challenge.Validators.TicketValidators
{
    public class TicketPostValidator : AbstractValidator<TicketPostDto>
    {
        public TicketPostValidator()
        {
            RuleFor(t => t.NumSeats)
                .GreaterThan(0).WithMessage("Number of seats must be greater than zero.")
                .LessThanOrEqualTo(10).WithMessage("Cannot book more than 10 seats at once.");
        }
    }
}
