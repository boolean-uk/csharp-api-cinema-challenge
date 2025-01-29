using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class UpdateMovieValidator : AbstractValidator<UpdateMovie>
{
    public UpdateMovieValidator()
    {
        RuleFor(m => m.Title)
            .MaximumLength(100).WithMessage("Title cannot exceed 100 characters.")
            .When(m => m.Title != null); // Validation applies only if Title is provided.

        RuleFor(m => m.Rating)
            .MaximumLength(10).WithMessage("Rating cannot exceed 10 characters.")
            .When(m => m.Rating != null); // Validation applies only if Rating is provided.

        RuleFor(m => m.Description)
            .MaximumLength(500).WithMessage("Description cannot exceed 500 characters.")
            .When(m => m.Description != null); // Validation applies only if Description is provided.

        RuleFor(m => m.RuntimeMins)
            .InclusiveBetween(1, 300).WithMessage("Runtime must be between 1 and 300 minutes.")
            .When(m => m.RuntimeMins != default); // Validation applies only if RuntimeMins is provided.
    }
}
