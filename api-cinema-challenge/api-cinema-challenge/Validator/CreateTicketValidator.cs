using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class CreateTicketValidator : AbstractValidator<CreateTicket>
{
    public CreateTicketValidator()
    {
        RuleFor(x => x.NumSeats)
            .NotEmpty().WithMessage("Number of seats is required.")
            .InclusiveBetween(1, 10).WithMessage("Number of seats must be between 1 and 10.");
    }
}
