using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class CreateCustomerValidator : AbstractValidator<CreateCustomer>
{
    public CreateCustomerValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(c => c.Phone)
            .NotEmpty().WithMessage("Phone is required.")
            .Matches(@"^\d{3}-\d{3}-\d{4}$").WithMessage("Phone must be in the format XXX-XXX-XXXX.");
    }
}
