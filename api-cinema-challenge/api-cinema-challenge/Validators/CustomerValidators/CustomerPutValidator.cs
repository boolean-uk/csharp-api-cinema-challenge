using api_cinema_challenge.DTOs.CustomerDTOs;
using FluentValidation;

namespace api_cinema_challenge.Validators.CustomerValidators
{
    public class CustomerPutValidator : AbstractValidator<CustomerPutDto>
    {
        public CustomerPutValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().When(x => x.Name != null).WithMessage("Name cannot be empty or whitespace.");

            RuleFor(x => x.Email)
                .NotEmpty().When(x => x.Email != null).WithMessage("Email cannot be empty.")
                .EmailAddress().When(x => x.Email != null).WithMessage("Email must be valid.");

            RuleFor(x => x.Phone)
                .NotEmpty().When(x => x.Phone != null).WithMessage("Phone cannot be empty.")
                .Matches(@"^\+?\d{7,15}$").When(x => x.Phone != null).WithMessage("Phone must be valid.");
        }
    }
}
