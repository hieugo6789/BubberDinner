using FluentValidation;

namespace BubberDinner.Application.Authentication.Commands.Register
{
    public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator() 
        {
            RuleFor(x => x.FirstName)
            .NotEmpty()
            .MinimumLength(6)
            .WithMessage("First name must be at least 6 characters long.");
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x =>x.Email).NotEmpty();
            RuleFor(x =>x.Password).NotEmpty();
        }
    }
}
