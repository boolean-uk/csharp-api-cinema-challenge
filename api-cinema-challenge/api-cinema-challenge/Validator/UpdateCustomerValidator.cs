using api_cinema_challenge.ViewModels;
using FluentValidation;
using System;

namespace api_cinema_challenge.Validator;
public class UpdateCustomerValidator : AbstractValidator<UpdateCustomer>
{
    public UpdateCustomerValidator()
    {
        RuleFor(c => c.Name)
            .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.")
            .When(c => c.Name != null); // Validation applies only if Name is provided.

        RuleFor(c => c.Email)
            .EmailAddress().WithMessage("Invalid email format.")
            .When(c => c.Email != null); // Validation applies only if Email is provided.

        RuleFor(c => c.Phone)
            .Matches(@"^\d{3}-\d{3}-\d{4}$").WithMessage("Phone must be in the format XXX-XXX-XXXX.")
            .When(c => c.Phone != null); // Validation applies only if Phone is provided.
    }
}
