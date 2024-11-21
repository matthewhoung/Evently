using Evently.Common.Application.Messaging;
using FluentValidation;

namespace Evently.Modules.Users.Application.Users.RegisterUser;
public sealed record class RegisterUserCommand(
    string Email,
    string Password,
    string FirstName,
    string LastName) : ICommand<Guid>;

internal sealed class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
{
    public RegisterUserCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Password)
            .NotEmpty()
            .MinimumLength(8);

        RuleFor(x => x.FirstName)
            .NotEmpty();

        RuleFor(x => x.LastName)
            .NotEmpty();
    }
}
