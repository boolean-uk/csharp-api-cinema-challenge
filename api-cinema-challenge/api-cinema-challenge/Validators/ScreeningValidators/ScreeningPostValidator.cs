using api_cinema_challenge.DTOs.MovieDTOs;
using api_cinema_challenge.DTOs.ScreeningDTOs;
using FluentValidation;

namespace api_cinema_challenge.Validators.ScreeningValidators
{
    public class ScreeningPostValidator : AbstractValidator<ScreeningPostDto>
    {
        public ScreeningPostValidator()
        {
            RuleFor(x => x.ScreenNumber)
                .GreaterThan(0).WithMessage("Screen number must be greater than 0.");

            RuleFor(x => x.Capacity)
                .GreaterThan(0).WithMessage("Capacity must be greater than 0.");

            RuleFor(x => x.StartsAt)
                .NotEmpty().WithMessage("StartsAt is required.");
        }
    }
}
