using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class CreateScreeningValidator : AbstractValidator<CreateScreening>
{
    public CreateScreeningValidator()
    {
        RuleFor(x => x.ScreenNumber)
            .NotEmpty().WithMessage("Screen number is required.")
            .InclusiveBetween(1, 20).WithMessage("Screen number must be between 1 and 20.");

        RuleFor(x => x.Capacity)
            .NotEmpty().WithMessage("Capacity is required.")
            .InclusiveBetween(10, 500).WithMessage("Capacity must be between 10 and 500.");

        RuleFor(x => x.StartsAt)
            .NotEmpty().WithMessage("Start time is required.")
            .Must(startsAt => startsAt > DateTime.UtcNow).WithMessage("Start time must be in the future.");

        RuleFor(x => x.MovieId)
            .NotEmpty().WithMessage("Movie ID is required.");
    }
}
