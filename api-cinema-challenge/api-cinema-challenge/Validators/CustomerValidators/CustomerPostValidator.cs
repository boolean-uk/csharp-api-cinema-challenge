using api_cinema_challenge.DTOs.CustomerDTOs;
using FluentValidation;

namespace api_cinema_challenge.Validators.CustomerValidators
{
    public class CustomerPostValidator : AbstractValidator<CustomerPostDto>
    {
        public CustomerPostValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Must(name => !string.IsNullOrWhiteSpace(name)).WithMessage("Name cannot be whitespace.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email must be a valid email address.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone is required.")
                .Matches(@"^\+?\d{7,15}$").WithMessage("Phone must be a valid phone number.");

        }

    }
}
