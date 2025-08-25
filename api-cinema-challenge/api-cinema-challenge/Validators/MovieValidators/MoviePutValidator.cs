using api_cinema_challenge.DTOs.MovieDTOs;
using FluentValidation;

namespace api_cinema_challenge.Validators.MovieValidators
{
    public class MoviePutValidator : AbstractValidator<MoviePutDto>
    {
        public MoviePutValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty()
                .When(m => m.Title != null)
                .WithMessage("Title cannot be empty or whitespace.");

            RuleFor(m => m.Rating)
                .NotEmpty()
                .When(m => m.Rating != null)
                .WithMessage("Rating cannot be empty or whitespace.");

            RuleFor(m => m.Description)
                .NotEmpty()
                .When(m => m.Description != null)
                .WithMessage("Description cannot be empty.")
                .MaximumLength(500)
                .When(m => m.Description != null)
                .WithMessage("Description must be at most 500 characters.");

            RuleFor(m => m.RuntimeMins)
                .GreaterThan(0)
                .When(m => m.RuntimeMins != null)
                .WithMessage("Runtime must be greater than 0 minutes.");
        }
    }
}
