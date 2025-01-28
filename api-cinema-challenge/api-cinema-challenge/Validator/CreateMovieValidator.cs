using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class CreateMovieValidator : AbstractValidator<CreateMovie>
{

    public CreateMovieValidator()
    {
        RuleFor(m => m.Title)
            .NotEmpty().WithMessage("Title is required.")
            .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.");

        RuleFor(m => m.Rating)
            .NotEmpty().WithMessage("Rating is required.")
            .MaximumLength(10).WithMessage("Rating cannot exceed 10 characters.");

        RuleFor(m => m.Description)
            .NotEmpty().WithMessage("Description is required.")
            .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.");

        RuleFor(m => m.RuntimeMins)
            .NotEmpty().WithMessage("Runtime is required.")
            .InclusiveBetween(1, 300).WithMessage("Runtime must be between 1 and 300 minutes.");

    }
}
