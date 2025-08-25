using api_cinema_challenge.DTOs.MovieDTOs;

using FluentValidation;

namespace api_cinema_challenge.Validators.MovieValidators
{
    public class MoviePostValidator : AbstractValidator<MoviePostDto>
    {
        public MoviePostValidator()
        {
            RuleFor(m => m.Title)
                .NotEmpty().WithMessage("Title is required.");

            RuleFor(m => m.Rating)
                .NotEmpty().WithMessage("Rating is required.");

            RuleFor(m => m.Description)
                .NotEmpty().WithMessage("Description is required.")
                .MaximumLength(500).WithMessage("Description must be at most 500 characters.");

            RuleFor(m => m.RuntimeMins)
                .GreaterThan(0).WithMessage("Runtime must be greater than 0 minutes.");
        }
    }
}
